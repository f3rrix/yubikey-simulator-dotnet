using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Yubikey.TokenSimulator
{
	public class HotkeyHandler : Control
	{
		private short _hookID = 0;

		public static HotkeyHandler Create(Keys key, int modifiers)
		{
			HotkeyHandler handler = new HotkeyHandler();
			try
			{
				handler._hookID = GlobalAddAtom(Thread.CurrentThread.ManagedThreadId.ToString("X8") + handler.Name);
				RegisterHotKey(handler.Handle, handler._hookID, modifiers,
					(int)key);
			}
			catch (Exception e)
			{
				if (handler._hookID != 0)
				{
					GlobalDeleteAtom(handler._hookID);
				}
				return null;
			}
			return handler;
		}

		protected override void WndProc(ref Message m)
		{
			// let the base class process the message
			base.WndProc(ref m);

			// if this is a WM_HOTKEY message, generate the otp
			if (m.Msg == 0x312)
			{
				OnHotKeyEvent(this, new EventArgs());
			}
		}

		public delegate void HotKeyEventHandler(object sender, EventArgs e);

		public event HotKeyEventHandler OnHotKeyEvent;

		protected override void Dispose(bool disposing)
		{
			if (_hookID != 0)
			{
				UnregisterHotKey(this.Handle, _hookID);
				GlobalDeleteAtom(_hookID);
			}
			base.Dispose(disposing);
		}

		[DllImport("user32", SetLastError = true)]
		private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
		[DllImport("user32", SetLastError = true)]
		private static extern int UnregisterHotKey(IntPtr hwnd, int id);
		[DllImport("kernel32", SetLastError = true)]
		private static extern short GlobalAddAtom(string lpString);
		[DllImport("kernel32", SetLastError = true)]
		private static extern short GlobalDeleteAtom(short nAtom);

		/*
		static class APIFuncs
		{
			public static int SetHotKey(IntPtr hwnd, int id, int fsModifiers, int vk)
			{
				return RegisterHotKey(hwnd, id, fsModifiers, vk);
			}
			public static int UnsetHotKey(IntPtr hwnd, int id)
			{
				return UnregisterHotKey(hwnd, id);
			}
			public static short AddAtom(string lpString)
			{
				return GlobalAddAtom(lpString);
			}
			public static short DeleteAtom(short nAtom)
			{
				return GlobalDeleteAtom(nAtom);
			}
		}
		*/
	}
}

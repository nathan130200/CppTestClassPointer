using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TestCallback_App
{
	public partial class Form1 : Form
	{
		IntPtr pInstance;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pInstance = MyClassPInvoker.MyClass_Initialize();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			MyClassPInvoker.MyClass_Shutdown(pInstance);
			base.OnClosing(e);
		}

		private void btnGetNumber_Click(object sender, EventArgs e)
		{
			textBox1.Text = MyClassPInvoker.MyClass_GetNumber(pInstance)
				.ToString();
		}

		private void btnSetNumber_Click(object sender, EventArgs e)
		{
			if(int.TryParse(textBox2.Text, out var number))
			{
				textBox2.Clear();
				MyClassPInvoker.MyClass_SetNumber(pInstance, number);
			}
		}

		private void btnGetName_Click(object sender, EventArgs e)
		{
			IntPtr pText = MyClassPInvoker.MyClass_GetName(pInstance);
			string text = Marshal.PtrToStringAnsi(pText);
			MessageBox.Show(text);
		}
	}

	public static class MyClassPInvoker
	{
		[DllImport("TestCallback_Lib", ExactSpelling = true)]
		public static extern IntPtr MyClass_Initialize();

		[DllImport("TestCallback_Lib", ExactSpelling = true)]
		public static extern void MyClass_Shutdown(IntPtr pInstance);

		[DllImport("TestCallback_Lib", ExactSpelling = true)]
		public static extern int MyClass_GetNumber(IntPtr pInstance);

		[DllImport("TestCallback_Lib", ExactSpelling = true)]
		public static extern void MyClass_SetNumber(IntPtr pInstance, int value);

		[DllImport("TestCallback_Lib", ExactSpelling = true)]
		public static extern IntPtr MyClass_GetName(IntPtr pInstance);
	}
}
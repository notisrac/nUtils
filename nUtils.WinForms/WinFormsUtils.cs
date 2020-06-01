using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nUtils.WinForms
{
    public static class WinFormsUtils
    {
        public static void InvokeMethod(this Control control, string method, object param)
        {
            InvokeMethod(control, method, new object[] { param });
        }

        public static void InvokeMethod(this Control control, string method, object[] parameters)
        {
            if (null == control || control.IsDisposed || control.Disposing)
            {
                return;
            }

            MethodInfo mi = typeof(Control).GetMethod(method);
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate { mi.Invoke(control, parameters); }));
            }
            else
            {
                mi.Invoke(control, parameters);
            }
        }

        public static void InvokeMember(this Control control, string member, object value)
        {
            if (null == control || control.IsDisposed || control.Disposing)
            {
                return;
            }

            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate { control.GetType().InvokeMember(member, BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, control, new object[] { value }); }));
            }
            else
            {
                control.GetType().InvokeMember(member, BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, Type.DefaultBinder, control, new object[] { value });
            }
        }
    }
}

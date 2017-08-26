using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using System.Windows.Forms;

namespace Tollcabin.My
{
    class MyProject
    {
        [StandardModule, HideModuleName, GeneratedCode("MyTemplate", "8.0.0.0")]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyForms
        {
            public Form1 m_Form1;

            public frmChoKetNoi m_frmChoKetNoi;

            public frmConfig m_frmConfig;

            public frmMain m_frmMain;

            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            public Form1 Form1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_Form1)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<Form1>(ref this.m_Form1);
                }
            }

            public frmChoKetNoi frmChoKetNoi
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmChoKetNoi = MyProject.MyForms.Create__Instance__<frmChoKetNoi>(this.m_frmChoKetNoi);
                    return this.m_frmChoKetNoi;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_frmChoKetNoi)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<frmChoKetNoi>(ref this.m_frmChoKetNoi);
                }
            }

            public frmConfig frmConfig
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmConfig = MyProject.MyForms.Create__Instance__<frmConfig>(this.m_frmConfig);
                    return this.m_frmConfig;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_frmConfig)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<frmConfig>(ref this.m_frmConfig);
                }
            }

            public frmMain frmMain
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
                    return this.m_frmMain;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_frmMain)
                    {
                        return;
                    }
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
                }
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    if (MyProject.MyForms.m_FormBeingCreated != null)
                    {
                        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                        }
                    }
                    else
                    {
                        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
                    }
                    MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        try
                        {
                            return Activator.CreateInstance<T>();
                        }
                        catch (Exception arg_74_0)
                        {
                            TargetInvocationException expr_79 = arg_74_0 as TargetInvocationException;
                            int arg_96_0;
                            if (expr_79 == null)
                            {
                                arg_96_0 = 0;
                            }
                            else
                            {
                                TargetInvocationException ex = expr_79;
                                ProjectData.SetProjectError(expr_79);
                                arg_96_0 = ((ex.InnerException != null) ? 1 : 0);
                            }
                            // Hoang comment endfilter(arg_96_0);
                        }
                    }
                    finally
                    {
                        MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
                    }
                    return Instance;
                }
                return Instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public MyForms()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyProject.MyForms);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            internal new Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override string ToString()
            {
                return base.ToString();
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public MyWebServices()
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public ThreadSafeObjectProvider()
            {
            }
        }

        private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

        private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

        private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

        private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

        private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Forms")]
        internal static MyProject.MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyFormsObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyProject.MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyWebServicesObjectProvider.GetInstance;
            }
        }
    }
}

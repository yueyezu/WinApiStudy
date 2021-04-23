using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace ACWinAPI
{
    public class User32
    {
        public const string LibraryName = "user32.dll";

        #region API常量:Constants

        /// <summary>
        /// 显示窗口类型
        /// </summary>
        [Flags]
        public enum ShowWindowCommands
        {
            /// <summary>
            /// 最小化一个窗口，即使拥有该窗口的线程没有响应。 仅当最小化来自其他线程的窗口时，才应使用此标志。
            /// </summary>
            SW_FORCEMINIMIZE = 11,

            /// <summary>
            /// 隐藏该窗口并激活另一个窗口。
            /// </summary>
            SW_HIDE = 0,

            /// <summary>
            /// 最大化指定的窗口。
            /// </summary>
            SW_MAXIMIZE = 3,

            /// <summary>
            /// 最小化指定的窗口并以Z顺序激活下一个顶级窗口。
            /// </summary>
            SW_MINIMIZE = 6,

            /// <summary>
            /// 激活并显示窗口。如果窗口最小化或最大化，则系统会将其还原到其原始大小和位置。恢复最小化窗口时，应用程序应指定此标志。
            /// </summary>
            SW_RESTORE = 9,

            /// <summary>
            /// 激活窗口并以其当前大小和位置显示它。
            /// </summary>
            SW_SHOW = 5,

            /// <summary>
            /// 根据启动应用程序的程序传递给CreateProcess函数的STARTUPINFO结构中指定的SW_值设置显示状态。
            /// </summary>
            SW_SHOWDEFAULT = 10,

            /// <summary>
            /// 激活窗口并将其显示为最大化窗口。
            /// </summary>
            SW_SHOWMAXIMIZED = 3,

            /// <summary>
            /// 激活窗口并将其显示为最小化窗口。
            /// </summary>
            SW_SHOWMINIMIZED = 2,

            /// <summary>
            /// 将窗口显示为最小化窗口。该值类似于SW_SHOWMINIMIZED，除了未激活窗口。
            /// </summary>
            SW_SHOWMINNOACTIVE = 7,

            /// <summary>
            /// 以当前大小和位置显示窗口。该值与SW_SHOW相似，不同之处在于未激活窗口。
            /// </summary>
            SW_SHOWNA = 8,

            /// <summary>
            /// 显示窗口的最新大小和位置。该值与SW_SHOWNORMAL相似，不同之处在于未激活窗口。
            /// </summary>
            SW_SHOWNOACTIVATE = 4,

            /// <summary>
            /// 激活并显示一个窗口。如果窗口最小化或最大化，则系统会将其还原到其原始大小和位置。首次显示窗口时，应用程序应指定此标志。
            /// </summary>
            SW_SHOWNORMAL = 1
        }

        /// <summary>
        /// 窗口标志
        /// </summary>
        [Flags]
        public enum WindowLongFlags
        {
            /// <summary>
            /// 检索扩展的窗口样式。
            /// </summary>
            GWL_EXSTYLE = -20,

            /// <summary>
            /// 检索应用程序实例的句柄。
            /// </summary>
            GWLP_HINSTANCE = -6,

            /// <summary>
            /// 检索父窗口的句柄（如果有）。
            /// </summary>
            GWLP_HWNDPARENT = -8,

            /// <summary>
            /// 检索窗口的标识符。
            /// </summary>
            GWLP_ID = -12,

            /// <summary>
            /// 检索窗口样式。
            /// </summary>
            GWL_STYLE = -16,

            /// <summary>
            /// 检索与窗口关联的用户数据。该数据供创建该窗口的应用程序使用。其值最初为零。
            /// </summary>
            GWLP_USERDATA = -21,

            /// <summary>
            /// 检索窗口过程的地址，或代表窗口过程的地址的句柄。您必须使用CallWindowProc函数来调用窗口过程。
            /// </summary>
            GWLP_WNDPROC = -4,

            /// <summary>
            /// 检索对话框过程的地址，或代表对话框过程的地址的句柄。您必须使用CallWindowProc函数来调用对话框过程。
            /// 注意:值应为 DWLP_MSGRESULT + sizeof（LRESULT）
            /// </summary>
            DWLP_DLGPROC = 0x4,

            /// <summary>
            /// 检索在对话框过程中处理的消息的返回值。
            /// </summary>
            DWLP_MSGRESULT = 0,

            /// <summary>
            /// 检索应用程序专用的额外信息，例如句柄或指针。
            /// 注意:值应为 DWLP_DLGPROC + sizeof(DLGPROC)
            /// </summary>
            DWLP_USER = 0x8
        }

        /// <summary>
        /// 窗口样式
        /// </summary>
        [Flags]
        public enum WindowStyles
        {
            /// <summary>
            ///     The window has a thin-line border.
            /// </summary>
            WS_BORDER = 0x00800000,

            /// <summary>
            ///     The window has a title bar (includes the WS_BORDER style).
            /// </summary>
            WS_CAPTION = 0x00C00000,

            /// <summary>
            ///     The window is a child window. A window with this style cannot have a menu bar. This style cannot be used with the
            ///     WS_POPUP style.
            /// </summary>
            WS_CHILD = 0x40000000,

            /// <summary>
            ///     Same as the WS_CHILD style.
            /// </summary>
            WS_CHILDWINDOW = 0x40000000,

            /// <summary>
            ///     Excludes the area occupied by child windows when drawing occurs within the parent window. This style is used when
            ///     creating the parent window.
            /// </summary>
            WS_CLIPCHILDREN = 0x02000000,

            /// <summary>
            ///     Clips child windows relative to each other; that is, when a particular child window receives a WM_PAINT message,
            ///     the WS_CLIPSIBLINGS style clips all other overlapping child windows out of the region of the child window to be
            ///     updated. If WS_CLIPSIBLINGS is not specified and child windows overlap, it is possible, when drawing within the
            ///     client area of a child window, to draw within the client area of a neighboring child window.
            /// </summary>
            WS_CLIPSIBLINGS = 0x04000000,

            /// <summary>
            ///     The window is initially disabled. A disabled window cannot receive input from the user. To change this after a
            ///     window has been created, use the EnableWindow function.
            /// </summary>
            WS_DISABLED = 0x08000000,

            /// <summary>
            ///     The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title
            ///     bar.
            /// </summary>
            WS_DLGFRAME = 0x00400000,

            /// <summary>
            ///     The window is the first control of a group of controls. The group consists of this first control and all controls
            ///     defined after it, up to the next control with the WS_GROUP style. The first control in each group usually has the
            ///     WS_TABSTOP style so that the user can move from group to group. The user can subsequently change the keyboard focus
            ///     from one control in the group to the next control in the group by using the direction keys.
            ///     You can turn this style on and off to change dialog box navigation. To change this style after a window has been
            ///     created, use the SetWindowLong function.
            /// </summary>
            WS_GROUP = 0x00020000,

            /// <summary>
            ///     The window has a horizontal scroll bar.
            /// </summary>
            WS_HSCROLL = 0x00100000,

            /// <summary>
            ///     The window is initially minimized. Same as the WS_MINIMIZE style.
            /// </summary>
            WS_ICONIC = 0x20000000,

            /// <summary>
            ///     The window is initially maximized.
            /// </summary>
            WS_MAXIMIZE = 0x01000000,

            /// <summary>
            ///     The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must
            ///     also be specified.
            /// </summary>
            WS_MAXIMIZEBOX = 0x00010000,

            /// <summary>
            ///     The window is initially minimized. Same as the WS_ICONIC style.
            /// </summary>
            WS_MINIMIZE = 0x20000000,

            /// <summary>
            ///     The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must
            ///     also be specified.
            /// </summary>
            WS_MINIMIZEBOX = 0x00020000,

            /// <summary>
            ///     The window is an overlapped window. An overlapped window has a title bar and a border. Same as the WS_TILED style.
            /// </summary>
            WS_OVERLAPPED = 0x00000000,

            /// <summary>
            ///     The window is an overlapped window. Same as the WS_TILEDWINDOW style.
            /// </summary>
            WS_OVERLAPPEDWINDOW =
                WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,

            /// <summary>
            ///     The windows is a pop-up window. This style cannot be used with the WS_CHILD style.
            /// </summary>
            WS_POPUP = unchecked((int)0x80000000),

            /// <summary>
            ///     The window is a pop-up window. The WS_CAPTION and WS_POPUPWINDOW styles must be combined to make the window menu
            ///     visible.
            /// </summary>
            WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU,

            /// <summary>
            ///     The window has a sizing border. Same as the WS_THICKFRAME style.
            /// </summary>
            WS_SIZEBOX = 0x00040000,

            /// <summary>
            ///     The window has a window menu on its title bar. The WS_CAPTION style must also be specified.
            /// </summary>
            WS_SYSMENU = 0x00080000,

            /// <summary>
            ///     The window is a control that can receive the keyboard focus when the user presses the TAB key. Pressing the TAB key
            ///     changes the keyboard focus to the next control with the WS_TABSTOP style.
            ///     You can turn this style on and off to change dialog box navigation. To change this style after a window has been
            ///     created, use the SetWindowLong function. For user-created windows and modeless dialogs to work with tab stops,
            ///     alter the message loop to call the IsDialogMessage function.
            /// </summary>
            WS_TABSTOP = 0x00010000,

            /// <summary>
            ///     The window has a sizing border. Same as the WS_SIZEBOX style.
            /// </summary>
            WS_THICKFRAME = 0x00040000,

            /// <summary>
            ///     The window is an overlapped window. An overlapped window has a title bar and a border. Same as the WS_OVERLAPPED
            ///     style.
            /// </summary>
            WS_TILED = 0x00000000,

            /// <summary>
            ///     The window is  an overlapped window. Same as the WS_OVERLAPPEDWINDOW style.
            /// </summary>
            WS_TILEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,

            /// <summary>
            ///     The window is initially visible.
            ///     This style can be turned on and off by using the ShowWindow or SetWindowPos function.
            /// </summary>
            WS_VISIBLE = 0x10000000,

            /// <summary>
            ///     The window has a vertical scroll bar.
            /// </summary>
            WS_VSCROLL = 0x00200000
        }

        /// <summary>
        /// 窗口扩展样式
        /// </summary>
        [Flags]
        public enum WindowExStyles
        {
            /// <summary>
            /// 该窗口接受拖放文件。
            /// </summary>
            WS_EX_ACCEPTFILES = 0x00000010,

            /// <summary>
            /// 可见时将顶级窗口强制到任务栏上。
            /// </summary>
            WS_EX_APPWINDOW = 0x00040000,

            /// <summary>
            /// 窗口的边框带有凹陷的边缘。
            /// </summary>
            WS_EX_CLIENTEDGE = 0x00000200,

            /// <summary>
            /// 使用双缓冲按从下到上的绘制顺序绘制窗口的所有后代。
            /// 如果窗口的类样式为CS_OWNDC或CS_CLASSDC，则不能使用此方法。 Windows 2000：不支持此样式。
            /// </summary>
            WS_EX_COMPOSITED = 0x02000000,

            /// <summary>
            ///     The title bar of the window includes a question mark. When the user clicks the question mark, the cursor changes to
            ///     a question mark with a pointer. If the user then clicks a child window, the child receives a WM_HELP message. The
            ///     child window should pass the message to the parent window procedure, which should call the WinHelp function using
            ///     the HELP_WM_HELP command. The Help application displays a pop-up window that typically contains help for the child
            ///     window.
            ///     WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
            /// </summary>
            WS_EX_CONTEXTHELP = 0x00000400,

            /// <summary>
            ///     The window itself contains child windows that should take part in dialog box navigation. If this style is
            ///     specified, the dialog manager recurses into children of this window when performing navigation operations such as
            ///     handling the TAB key, an arrow key, or a keyboard mnemonic.
            /// </summary>
            WS_EX_CONTROLPARENT = 0x00010000,

            /// <summary>
            ///     The window has a double border; the window can, optionally, be created with a title bar by specifying the
            ///     WS_CAPTION style in the dwStyle parameter.
            /// </summary>
            WS_EX_DLGMODALFRAME = 0x00000001,

            /// <summary>
            ///     The window is a layered window. This style cannot be used if the window has a class style of either CS_OWNDC or
            ///     CS_CLASSDC.
            ///     Windows 8:  The WS_EX_LAYERED style is supported for top-level windows and child windows. Previous Windows versions
            ///     support WS_EX_LAYERED only for top-level windows.
            /// </summary>
            WS_EX_LAYERED = 0x00080000,

            /// <summary>
            ///     If the shell language is Hebrew, Arabic, or another language that supports reading order alignment, the horizontal
            ///     origin of the window is on the right edge. Increasing horizontal values advance to the left.
            /// </summary>
            WS_EX_LAYOUTRTL = 0x00400000,

            /// <summary>
            /// 该窗口具有通用的左对齐属性。 这是默认值。
            /// </summary>
            WS_EX_LEFT = 0x00000000,

            /// <summary>
            /// 如果外壳语言是希伯来语，阿拉伯语或其他支持阅读顺序对齐的语言，则垂直滚动条（如果有）位于客户区域的左侧。 对于其他语言，样式将被忽略。
            /// </summary>
            WS_EX_LEFTSCROLLBAR = 0x00004000,

            /// <summary>
            /// 使用从左到右的阅读顺序属性显示窗口文本。 这是默认值。
            /// </summary>
            WS_EX_LTRREADING = 0x00000000,

            /// <summary>
            /// 该窗口是MDI子窗口。
            /// </summary>
            WS_EX_MDICHILD = 0x00000040,

            /// <summary>
            /// 当用户单击它时，以这种样式创建的顶级窗口不会成为前台窗口。 当用户最小化或关闭前景窗口时，系统不会将此窗口置于前景。 
            /// 要激活该窗口，请使用SetActiveWindow或SetForegroundWindow函数。
            /// 默认情况下，该窗口不显示在任务栏上。 要强制窗口显示在任务栏上，请使用WS_EX_APPWINDOW样式。
            /// </summary>
            WS_EX_NOACTIVATE = 0x08000000,

            /// <summary>
            /// 该窗口不会将其窗口布局传递给其子窗口。
            /// </summary>
            WS_EX_NOINHERITLAYOUT = 0x00100000,

            /// <summary>
            /// 使用此样式创建的子窗口在创建或销毁时不会将WM_PARENTNOTIFY消息发送到其父窗口。
            /// </summary>
            WS_EX_NOPARENTNOTIFY = 0x00000004,

            /// <summary>
            ///     The window does not render to a redirection surface. This is for windows that do not have visible content or that
            ///     use mechanisms other than surfaces to provide their visual.
            /// </summary>
            WS_EX_NOREDIRECTIONBITMAP = 0x00200000,

            /// <summary>
            ///     The window is an overlapped window.
            /// </summary>
            WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,

            /// <summary>
            ///     The window is palette window, which is a modeless dialog box that presents an array of commands.
            /// </summary>
            WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,

            /// <summary>
            ///     The window has generic "right-aligned" properties. This depends on the window class. This style has an effect only
            ///     if the shell language is Hebrew, Arabic, or another language that supports reading-order alignment; otherwise, the
            ///     style is ignored.
            ///     Using the WS_EX_RIGHT style for static or edit controls has the same effect as using the SS_RIGHT or ES_RIGHT
            ///     style, respectively. Using this style with button controls has the same effect as using BS_RIGHT and BS_RIGHTBUTTON
            ///     styles.
            /// </summary>
            WS_EX_RIGHT = 0x00001000,

            /// <summary>
            /// 垂直滚动条（如果有）在客户区域的右侧。 这是默认值。
            /// </summary>
            WS_EX_RIGHTSCROLLBAR = 0x00000000,

            /// <summary>
            /// 如果外壳语言是希伯来语，阿拉伯语或其他支持阅读顺序对齐的语言，则使用从右到左的阅读顺序属性显示窗口文本。 对于其他语言，样式将被忽略。
            /// </summary>
            WS_EX_RTLREADING = 0x00002000,

            /// <summary>
            /// 该窗口具有三维边框样式，旨在用于不接受用户输入的项目。
            /// </summary>
            WS_EX_STATICEDGE = 0x00020000,

            /// <summary>
            /// 该窗口旨在用作浮动工具栏。 工具窗口的标题栏比普通标题栏短，并且窗口标题使用较小的字体绘制。 
            /// 当用户按下ALT + TAB时，工具窗口不会出现在任务栏或对话框中。
            /// 如果工具窗口具有系统菜单，则其图标不会显示在标题栏上。 
            /// 但是，您可以通过右键单击或键入ALT + SPACE来显示系统菜单。
            /// </summary>
            WS_EX_TOOLWINDOW = 0x00000080,

            /// <summary>
            /// 该窗口应放置在所有非最上面的窗口之上，并且即使在停用该窗口的情况下也应保持在它们之上。 若要添加或删除此样式，请使用SetWindowPos函数。
            /// </summary>
            WS_EX_TOPMOST = 0x00000008,

            /// <summary>
            /// 在绘制窗口下方的兄弟姐妹（由同一线程创建）之前，不应绘制窗口。 
            /// 该窗口显示为透明，因为基础同级窗口的位已被绘制。 要获得透明性而没有这些限制，请使用SetWindowRgn函数。
            /// </summary>
            WS_EX_TRANSPARENT = 0x00000020,

            /// <summary>
            /// 窗口的边框带有凸起的边缘。
            /// </summary>
            WS_EX_WINDOWEDGE = 0x00000100
        }

        /// <summary>
        /// 窗口位置标志
        /// </summary>
        [Flags]
        public enum WindowPositionFlags
        {
            /// <summary>
            ///     If the calling thread and the thread that owns the window are attached to different input queues, the system posts
            ///     the request to the thread that owns the window. This prevents the calling thread from blocking its execution while
            ///     other threads process the request.
            /// </summary>
            SWP_ASYNCWINDOWPOS = 0x4000,

            /// <summary>
            ///     Prevents generation of the WM_SYNCPAINT message.
            /// </summary>
            SWP_DEFERERASE = 0x2000,

            /// <summary>
            ///     Draws a frame (defined in the window's class description) around the window.
            /// </summary>
            SWP_DRAWFRAME = 0x0020,

            /// <summary>
            ///     Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, even if
            ///     the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's
            ///     size is being changed.
            /// </summary>
            SWP_FRAMECHANGED = 0x0020,

            /// <summary>
            ///     Hides the window.
            /// </summary>
            SWP_HIDEWINDOW = 0x0080,

            /// <summary>
            ///     Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the
            ///     topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
            /// </summary>
            SWP_NOACTIVATE = 0x0010,

            /// <summary>
            ///     Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client
            ///     area are saved and copied back into the client area after the window is sized or repositioned.
            /// </summary>
            SWP_NOCOPYBITS = 0x0100,

            /// <summary>
            ///     Retains the current position (ignores X and Y parameters).
            /// </summary>
            SWP_NOMOVE = 0x0002,

            /// <summary>
            ///     Does not change the owner window's position in the Z order.
            /// </summary>
            SWP_NOOWNERZORDER = 0x0200,

            /// <summary>
            ///     Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area,
            ///     the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a
            ///     result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any
            ///     parts of the window and parent window that need redrawing.
            /// </summary>
            SWP_NOREDRAW = 0x0008,

            /// <summary>
            ///     Same as the SWP_NOOWNERZORDER flag.
            /// </summary>
            SWP_NOREPOSITION = 0x0200,

            /// <summary>
            ///     Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
            /// </summary>
            SWP_NOSENDCHANGING = 0x0400,

            /// <summary>
            ///     Retains the current size (ignores the cx and cy parameters).
            /// </summary>
            SWP_NOSIZE = 0x0001,

            /// <summary>
            ///     Retains the current Z order (ignores the hWndInsertAfter parameter).
            /// </summary>
            SWP_NOZORDER = 0x0004,

            /// <summary>
            ///     Displays the window.
            /// </summary>
            SWP_SHOWWINDOW = 0x0040
        }

        /// <summary>
        /// 窗口Z轴标志
        /// </summary>
        public enum HwndZOrder
        {
            /// <summary>
            ///     Places the window at the bottom of the Z order. If the hWnd parameter identifies a topmost window, the window loses
            ///     its topmost status and is placed at the bottom of all other windows.
            /// </summary>
            HWND_BOTTOM = 1,

            /// <summary>
            ///     Places the window above all non-topmost windows (that is, behind all topmost windows). This flag has no effect if
            ///     the window is already a non-topmost window.
            /// </summary>
            HWND_NOTOPMOST = -2,

            /// <summary>
            ///     Places the window at the top of the Z order.
            /// </summary>
            HWND_TOP = 0,

            /// <summary>
            ///     Places the window above all non-topmost windows. The window maintains its topmost position even when it is
            ///     deactivated.
            /// </summary>
            HWND_TOPMOST = -1
        }
        #endregion

        #region 结构:struct
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle rect)
            {
                Left = rect.Left;
                Top = rect.Top;
                Right = rect.Right;
                Bottom = rect.Bottom;
            }

            public Rectangle Rect
            {
                get
                {
                    return new Rectangle(
                        Left,
                        Top,
                        Right - Left,
                        Bottom - Top);
                }
            }

            public Size Size
            {
                get
                {
                    return new Size(Right - Left, Bottom - Top);
                }
            }

            public static RECT FromXYWH(int x, int y, int width, int height)
            {
                return new RECT(x,
                                y,
                                x + width,
                                y + height);
            }

            public static RECT FromRectangle(Rectangle rect)
            {
                return new RECT(rect.Left,
                                 rect.Top,
                                 rect.Right,
                                 rect.Bottom);
            }
        }
        #endregion

        #region 回调函数
        /// <summary>
        /// 回调函数-与EnumWindows或EnumDesktopWindows函数一起使用的应用程序定义的回调函数。它接收顶级窗口句柄。
        /// WNDENUMPROC类型定义一个指向此回调函数的指针。
        /// EnumWindowsProc是应用程序定义的函数名称的占位符。
        /// </summary>
        /// <param name="hWnd">顶层窗口的句柄。</param>
        /// <param name="lParam">在EnumWindows或EnumDesktopWindows中给出的应用程序定义的值。</param>
        /// <returns></returns>
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        #endregion

        /// <summary>
        /// 通过将句柄传递给每个窗口，依次传递给应用程序定义的回调函数，可以枚举屏幕上所有的顶级窗口。
        /// EnumWindows继续，直到枚举最后一个顶级窗口或回调函数返回FALSE。
        /// </summary>
        /// <param name="lpEnumFunc">指向应用程序定义的回调函数的指针。</param>
        /// <param name="lParam">应用程序定义的值，将传递给回调函数。</param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// 枚举与指定桌面关联的所有顶级窗口。它将句柄传递给每个窗口，依次传递给应用程序定义的回调函数。
        /// </summary>
        /// <param name="hDesktop">要枚举其顶级窗口的桌面的句柄。该句柄由CreateDesktop，GetThreadDesktop，OpenDesktop或OpenInputDesktop函数返回，并且必须具有DESKTOP_READOBJECTS访问权限。有关更多信息，请参见桌面安全和访问权限。如果此参数为NULL，则使用当前桌面。</param>
        /// <param name="lpEnumFunc">指向应用程序定义的EnumWindowsProc回调函数的指针。</param>
        /// <param name="lParam">应用程序定义的值，将传递给回调函数。</param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// 将指定窗口标题栏的文本（如果有的话）复制到缓冲区中。
        /// 如果指定的窗口是控件，则复制控件的文本。
        /// 但是，GetWindowText无法在另一个应用程序中检索控件的文本。
        /// </summary>
        /// <param name="hWnd">包含文本的窗口或控件的句柄</param>
        /// <param name="lpString">将接收文本的缓冲区。如果字符串与缓冲区一样长或更长，则字符串将被截断并以空字符终止。</param>
        /// <param name="nMaxCount">要复制到缓冲区的最大字符数，包括空字符。如果文本超过此限制，则会被截断。</param>
        /// <returns></returns>
        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// 检索指定窗口的标题栏文本的长度（以字符为单位）（如果窗口具有标题栏）。
        /// 如果指定的窗口是控件，则该函数将检索控件内文本的长度。
        /// 但是，GetWindowTextLength无法在另一个应用程序中检索编辑控件的文本长度。
        /// </summary>
        /// <param name="hWnd">窗口或控件的句柄。</param>
        /// <returns></returns>
        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        /// <summary>
        /// 确定指定窗口的可见性状态。
        /// </summary>
        /// <param name="hwnd">要测试的窗口的句柄。</param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern bool IsWindowVisible(IntPtr hwnd);

        /// <summary>
        /// 检索创建指定窗口的线程的标识符，以及可选的创建窗口的进程的标识符。
        /// </summary>
        /// <param name="hWnd">窗口的句柄。</param>
        /// <param name="processId">
        /// 指向接收进程标识符的变量的指针。
        /// 如果此参数不为NULL，则GetWindowThreadProcessId将进程的标识符复制到该变量；否则，不会复制。
        /// </param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr processId);

        /// <summary>
        /// 检索顶级窗口的句柄，该窗口的类名和窗口名与指定的字符串匹配。此功能不搜索子窗口。
        /// 此功能不执行区分大小写的搜索。要从指定的子窗口开始搜索子窗口，请使用FindWindowEx函数。
        /// </summary>
        /// <param name="lpClassName">
        /// [Type: LPCTSTR]
        /// 通过先前调用RegisterClass或RegisterClassEx函数创建的类名称或类原子。
        /// 原子必须在lpClassName的低位单词中；高阶字必须为零。如果lpClassName指向一个字符串，则它指定窗口类名称。
        /// 类名可以是在RegisterClass或RegisterClassEx中注册的任何名称，也可以是任何预定义的控件类名称。
        /// 如果lpClassName为NULL，它将找到标题与lpWindowName参数匹配的任何窗口。
        /// </param>
        /// <param name="lpWindowName">
        /// [Type: LPCTSTR]
        /// 窗口名称（窗口标题）。如果此参数为NULL，则所有窗口名称均匹配。
        /// </param>
        /// <returns></returns>
        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 检索其类名和窗口名与指定字符串匹配的窗口的句柄。该功能搜索子窗口，从指定子窗口之后的子窗口开始。此功能不执行区分大小写的搜索。
        /// </summary>
        /// <param name="hwndParent">
        /// [Type: HWND]
        /// 要搜索其子窗口的父窗口的句柄。如果hwndParent为NULL，则该函数将桌面窗口用作父窗口。
        /// 该功能在作为桌面子窗口的窗口之间搜索。如果hwndParent为HWND_MESSAGE，则该函数搜索所有仅消息窗口。
        /// </param>
        /// <param name="hwndChildAfter">
        /// [Type: HWND]
        /// 子窗口的句柄。搜索从Z顺序的下一个子窗口开始。子窗口必须是hwndParent的直接子窗口，而不仅仅是后代窗口。
        /// 如果hwndChildAfter为NULL，则搜索从hwndParent的第一个子窗口开始。
        /// 请注意，如果hwndParent和hwndChildAfter均为NULL，则该函数将搜索所有顶级和仅消息窗口。
        /// </param>
        /// <param name="lpszClass">
        /// [Type: LPCTSTR]
        /// 通过先前调用RegisterClass或RegisterClassEx函数创建的类名称或类原子。
        /// 原子必须放在lpszClass的低位字中；高阶字必须为零。如果lpszClass是一个字符串，则它指定窗口类名称。
        /// 类名可以是在RegisterClass或RegisterClassEx中注册的任何名称，也可以是任何预定义的控件类名称，也可以是MAKEINTATOM（0x8000）。
        /// 在后一种情况下，0x8000是菜单类的原子。
        /// </param>
        /// <param name="lpszWindow">
        /// [Type: LPCTSTR]
        /// 窗口名称（窗口标题）。如果此参数为NULL，则所有窗口名称均匹配。
        /// </param>
        /// <returns>[Type: HWND]</returns>
        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        /// <summary>
        /// 设置指定窗口的显示状态。
        /// </summary>
        /// <param name="hwnd">窗口的句柄</param>
        /// <param name="nCmdShow">
        /// [Type: int]
        /// 控制窗口的显示方式。
        /// 如果启动应用程序的程序提供了STARTUPINFO结构，则在应用程序首次调用ShowWindow时将忽略此参数。
        /// 否则，第一次调用ShowWindow时，该值应为WinMain函数在其nCmdShow参数中获得的值。
        /// </param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern bool ShowWindow(IntPtr hwnd, ShowWindowCommands nCmdShow);

        /// <summary>
        /// 检索指定窗口的边界矩形的尺寸。尺寸以相对于屏幕左上角的屏幕坐标给出。
        /// </summary>
        /// <param name="hwnd">[Type:HWND] 窗口的句柄。</param>
        /// <param name="lpRect">[Type：LPRECT] 指向RECT结构的指针，该结构接收窗口左上角和右下角的屏幕坐标。</param>
        /// <returns>如果函数成功，则返回值为非零。如果函数失败，则返回值为零。若要获取扩展的错误信息，请调用GetLastError。</returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, ref RECT lpRect);

        // 此静态方法是必需的，因为Win32不直接支持GetWindowLongPtr
        /// <summary>
        /// 检索有关指定窗口的信息。该函数还将指定偏移量的值检索到额外的窗口存储器中。
        /// 注意要编写与32位和64位版本的Windows兼容的代码，请使用GetWindowLongPtr。
        /// 当为32位Windows进行编译时，GetWindowLongPtr被定义为对GetWindowLong函数的调用。
        /// </summary>
        /// <param name="hwnd">[Type:HWND]窗口的句柄，间接地，窗口所属的类。</param>
        /// <param name="nIndex">
        /// [Type:int] 
        /// 从零开始的要获取值的偏移量。有效值的范围是零到额外的窗口内存的字节数减去LONG_PTR的大小。要检索其他任何值，请指定以下值之一。
        /// 应为枚举WindowLongFlags的值
        /// </param>
        /// <returns>[Type:LONG_PTR] 如果函数成功，则返回值为请求的值。</returns>
        public static IntPtr GetWindowLongPtr(IntPtr hwnd, int nIndex)
        {
            return IntPtr.Size > 4
                ? GetWindowLongPtr_x64(hwnd, nIndex)
                : new IntPtr(GetWindowLong(hwnd, nIndex));
        }

        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        private static extern int GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport(LibraryName, CharSet = CharSet.Unicode, EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr_x64(IntPtr hwnd, int nIndex);

        // 此静态方法是必需的，因为Win32不直接支持GetWindowLongPtr
        /// <summary>
        /// 更改指定窗口的属性。该函数还在附加窗口存储器中的指定偏移处设置一个值。
        /// 注意要编写与32位和64位版本的Windows兼容的代码，请使用SetWindowLongPtr。
        /// 当为32位Windows进行编译时，SetWindowLongPtr被定义为对SetWindowLong函数的调用。
        /// </summary>
        /// <param name="hwnd">
        /// [Type:HWND]
        /// 窗口的句柄，间接地，窗口所属的类。
        /// 如果拥有hWnd参数指定的窗口的进程在UIPI层次结构中具有比调用线程所驻留的进程更高的进程特权，则SetWindowLongPtr函数将失败。
        /// </param>
        /// <param name="nIndex">
        /// [Type:int] 
        /// 从零开始的要设置值的偏移量。有效值的范围是零到额外的窗口内存的字节数减去LONG_PTR的大小。要设置任何其他值，请指定以下值之一。
        /// 应为枚举WindowLongFlags的值
        /// </param>
        /// <param name="dwNewLong">替换值。</param>
        /// <returns>[Type:LONG_PTR] 如果函数成功，则返回值是指定偏移量的先前值。</returns>
        public static IntPtr SetWindowLongPtr(IntPtr hwnd, int nIndex, IntPtr dwNewLong)
        {
            return IntPtr.Size > 4
                ? SetWindowLongPtr_x64(hwnd, nIndex, dwNewLong)
                : new IntPtr(SetWindowLong(hwnd, nIndex, dwNewLong.ToInt32()));
        }

        [DllImport(LibraryName, CharSet = CharSet.Unicode)]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport(LibraryName, CharSet = CharSet.Unicode, EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr_x64(IntPtr hwnd, int nIndex, IntPtr dwNewLong);

        /// <summary>
        /// 更改子窗口，弹出窗口或顶级窗口的大小，位置和Z顺序。这些窗口是根据其在屏幕上的外观排序的。
        /// 最顶部的窗口获得最高排名，并且是Z顺序中的第一个窗口。
        /// </summary>
        /// <param name="hwnd" type=HWND>窗口的句柄。</param>
        /// <param name="hWndInsertAfter" type=HWND>
        /// 在Z顺序中位于定位的窗口之前的窗口的句柄。此参数必须是窗口句柄或以下值之一。
        /// 应为枚举 HwndZOrder 的值
        /// </param>
        /// <param name="x" type=int>窗口左侧的新位置，以客户坐标表示。</param>
        /// <param name="y" type=int>窗口顶部的新位置，以客户坐标表示。</param>
        /// <param name="cx" type=int>窗口的新宽度，以像素为单位。</param>
        /// <param name="cy" type=int>窗口的新高度，以像素为单位。</param>
        /// <param name="flags" type=uint>
        /// 窗口大小和位置标志。此参数可以是以下值的组合。
        /// 应为枚举 WindowPositionFlags 的值
        /// </param>
        /// <returns></returns>
        [DllImport(LibraryName, ExactSpelling = true)]
        public static extern bool SetWindowPos(IntPtr hwnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, WindowPositionFlags flags);
    }
}

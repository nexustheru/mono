//
// System.Windows.Forms.FileDialog.cs
//
// Author:
//   stubbed out by Daniel Carrera (dcarrera@math.toronto.edu)
//   Dennis Hayes (dennish@raytek.com)
// (C) 2002 Ximian, Inc
//
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms {

	// <summary>
	//
	// </summary>

    public abstract class FileDialog : CommonDialog {
		internal string fileName = "";
		internal const  int MAX_PATH = 512;
		//
		//  --- Public Properties
		//
		[MonoTODO]
		public bool AddExtension {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public virtual bool CheckFileExists {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public bool CheckPathExists {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public string DefaultExt {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public bool DereferenceLinks {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public string FileName {
			get {
				return fileName;
			}
			set {
				fileName = value;
			}
		}
		[MonoTODO]
		public string[] FileNames {
			get {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public string Filter {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public int FilterIndex {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public string InitialDirectory {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public bool RestoreDirectory {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public bool ShowHelp {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public string Title {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public bool ValidateNames {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		//
		//  --- Public Methods
		//


		[MonoTODO]
		public override void Reset()
		{
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public override string ToString()
		{
			//FIXME:
			return base.ToString();
		}

		//
		// --- Public Events
		//

		public event CancelEventHandler FileOk;
		//
		// --- Protected Methods
		//

		[MonoTODO]
		protected  override IntPtr HookProc( IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam )
		{
			//FIXME:
			return base.HookProc(hWnd, msg, wparam, lparam);
		}
		[MonoTODO]
		protected  void OnFileOk( CancelEventArgs e)
		{
			//FIXME:
		}
		[MonoTODO]
		protected  override bool RunDialog( IntPtr hWndOwner )
		{
			OPENFILENAME opf = new OPENFILENAME (  );
			char[] FileNameBuffer = new char[MAX_PATH];

			opf.lStructSize  = (uint)Marshal.SizeOf( opf );
			opf.lpstrFile = new string( FileNameBuffer );
			opf.nMaxFile = (uint) opf.lpstrFile.Length;
			opf.hwndOwner = hWndOwner;
			opf.lpfnHook  = new Win32.FnHookProc ( base.HookProc );

			bool res = Win32.GetOpenFileName ( ref opf );
			if ( res ) {
				FileName = opf.lpstrFile;
			}
			return res;
		}
	 }
}

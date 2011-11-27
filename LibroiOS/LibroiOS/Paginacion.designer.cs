// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace LibroiOS
{
	[Register ("Paginacion")]
	partial class Paginacion
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView Imagen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblPagina { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Imagen != null) {
				Imagen.Dispose ();
				Imagen = null;
			}

			if (lblPagina != null) {
				lblPagina.Dispose ();
				lblPagina = null;
			}
		}
	}
}

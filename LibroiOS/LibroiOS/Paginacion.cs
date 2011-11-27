
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
namespace LibroiOS
{
	public partial class Paginacion : UIViewController
	{
		public Paginacion (int indice) : base ("Paginacion", null)
		{
			this.Indice = indice;
		}		
		public int Indice
		{
			get;
			private set;
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Imagen.Image = UIImage.FromFile (string.Format 
			              ("imagenes/viaje{0}.jpg", Indice + 1));
			this.lblPagina.Text = string.Format ("Página {0}", 
			                                     Indice + 1);
		}
	}
}



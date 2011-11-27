using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace LibroiOS
{
	public partial class LibroiOSViewController : UIViewController
	{
		public UIPageViewController ControladorVistas;
		private int ContadorPag = 4;
		public LibroiOSViewController () : base ("LibroiOSViewController", null)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Paginacion PrimeraP = new Paginacion(0);
			ControladorVistas = new UIPageViewController
				(UIPageViewControllerTransitionStyle.PageCurl, 
				 UIPageViewControllerNavigationOrientation.Horizontal,
				 UIPageViewControllerSpineLocation.Min);
			ControladorVistas.SetViewControllers 
				(new UIViewController[]{PrimeraP},
				UIPageViewControllerNavigationDirection.Forward, 
				false, s => { });
			ControladorVistas.GetNextViewController = this.SiguientePagina;
			ControladorVistas.GetPreviousViewController = this.PaginaPrevia;
			ControladorVistas.View.Frame = this.View.Bounds;
			this.View.AddSubview (this.ControladorVistas.View);
		}
		private UIViewController SiguientePagina
			(UIPageViewController controlador, 
			 UIViewController Controladorbase)
		{
			Paginacion PaginaActual = Controladorbase 
				as Paginacion;
			if (PaginaActual.Indice >= (this.ContadorPag - 1))
		{
			return null;
		}else
		{
			int siguiente = PaginaActual.Indice + 1;
			return new Paginacion(siguiente);
		}
	}
	private UIViewController PaginaPrevia 
		(UIPageViewController controlador, UIViewController 
			 Controladorbase)
		{
			Paginacion PaginaActual = Controladorbase
				as Paginacion;
			if (PaginaActual.Indice <+ 0)
	{
		return null;
	}else
	{
			int paginaPrevia = PaginaActual.Indice - 1;
			return new Paginacion(paginaPrevia);
	}
}
	}
}


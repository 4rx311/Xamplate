﻿using System;
using Xamarin.Forms;

namespace $safeprojectname$.Interfaces
{
	public interface IViewFactory
	{
		void Register<TViewModel, TView>() where TViewModel : class, IViewModelBase where TView : Page;
		Page Resolve<TViewModel>() where TViewModel : class, IViewModelBase;
	}
}

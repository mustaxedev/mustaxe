using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mustaxe.Infra;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mustaxe.Controllers
{
	public class BaseController : Controller
	{
		public void Success(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Success, message, dismissable);
		}

		public void Information(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Information, message, dismissable);
		}

		public void Warning(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Warning, message, dismissable);
		}

		public void Danger(string message, bool dismissable = false)
		{
			AddAlert(AlertStyles.Danger, message, dismissable);
		}

		private void AddAlert(string alertStyle, string message, bool dismissable)
		{
			var alerta = new Alert
			{
				AlertStyle = alertStyle,
				Message = message,
				Dismissable = dismissable
			};

			TempData[Alert.TempDataKey] = alerta;
		}
	}
}

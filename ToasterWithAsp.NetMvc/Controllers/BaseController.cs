using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToasterWithAsp.NetMvc.POCO;

namespace ToasterWithAsp.NetMvc.Controllers
{
    /// <summary>
    /// Base controller for application
    /// </summary>
    public class BaseController : Controller
    {
        // Display message stocked in TempData in view
        public ActionResult OperationComplete()
        {
            if(TempData.ContainsKey(Message.Key))
            {
                return PartialView("_OperationComplete", TempData[Message.Key]);
            }
            else
            {
                return new EmptyResult();
            }
        }

        /// <summary>
        /// Add success message for display in TempData
        /// </summary>
        /// <param name="message"></param>
        protected void AddSuccessMessage(string message)
        {
            TempData[Message.Key] = new Message(message, MessageType.Success);
        }

        /// <summary>
        /// Add info message for display in TempData
        /// </summary>
        /// <param name="message"></param>
        protected void AddInfoMessage(string message)
        {
            TempData[Message.Key] = new Message(message, MessageType.Info);
        }

        /// <summary>
        /// Add warning message for display in TempData
        /// </summary>
        /// <param name="message"></param>
        protected void AddWarningMessage(string message)
        {
            TempData[Message.Key] = new Message(message, MessageType.Warning);
        }

        /// <summary>
        /// Add error message for display in TempData
        /// </summary>
        /// <param name="message"></param>
        protected void AddErrorMessage(string message)
        {
            TempData[Message.Key] = new Message(message, MessageType.Error);
        }
    }
}
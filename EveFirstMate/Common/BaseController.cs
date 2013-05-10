using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EveFirstMate.Common
{
    public abstract partial class BaseController : Controller
    {
        /// <summary>
        /// Creates a JsonNetResult object that serializes the specified
        /// object to JavaScript Object Notation (JSON) format.
        /// </summary>
        /// <param name="data">The JavaScript object graph to serialize.</param>
        /// <param name="contentType">The content type (MIME type).</param>
        /// <param name="contentEncoding">The content encoding.</param>
        /// <returns>
        /// The JSON result object that serializes the specified object to JSON format.
        /// </returns>
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding)
        {
            return Json(data, contentType, contentEncoding, JsonRequestBehavior.DenyGet);
        }

        /// <summary>
        /// Creates a JsonNetResult object that serializes the specified
        /// object to JavaScript Object Notation (JSON) format using the content type,
        /// content encoding, and the JSON request behavior.
        /// </summary>
        /// <param name="data">The JavaScript object graph to serialize.</param>
        /// <param name="contentType">The content type (MIME type).</param>
        /// <param name="contentEncoding">The content encoding.</param>
        /// <param name="behavior">The JSON request behavior</param>
        /// <returns>
        /// The result object that serializes the specified object to JSON format.
        /// </returns>
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }
    }
}
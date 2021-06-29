using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Generic Response Model is representation of response from complex object type
    /// </summary>
    public class GenericResponseModel<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether [status].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [status]; otherwise, <c>false</c>.
        /// </value>
        public Boolean Status { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public Dictionary<string, List<string>> Message { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// Value represent the response of method
        /// Primitive Type, Object, User-Defined Object, etc
        /// String, Int, Boolean, DataTable, DataSet
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public T Data { get; set; }

        /// <summary>
        /// Determines whether [has error message].
        /// </summary>
        /// <returns></returns>
        /// 
        [JsonIgnore]
        public int HttpStatus { get; set; }

        public Boolean HasErrorMessage
        {
            get
            {
                var hasErrorMessage = this.GetAllErrorMessage().Count > 0 ? true : false;
                return hasErrorMessage;
            }
            set { }
        }

        /// <summary>
        /// Determines whether [has warning message].
        /// </summary>
        /// <returns></returns>
        public Boolean HasWarningMessage
        {
            get
            {
                var hasWarningMessage = this.GetAllWarningMessage().Count > 0 ? true : false;
                return hasWarningMessage;
            }
            set { }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResponseModel"/> class.
        /// </summary>
        public GenericResponseModel()
        {
            Status = false;
            Message = new Dictionary<string, List<string>>{
                {"error", new List<string>()},
                {"warning", new List<string>()},
                {"info", new List<string>()}
            };
            Data = default(T);
        }

        /// <summary>
        /// Copies the response message.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="responseModel">The response model.</param>
        public void CopyResponseMessage<T>(GenericResponseModel<T> responseModel)
        {
            SetErrorMessage(responseModel.GetAllErrorMessage());
            SetWarningMessage(responseModel.GetAllWarningMessage());
        }

        /// <summary>
        /// Sets the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetErrorMessage(string message)
        {
            SetMessage(message, "error");
        }

        /// <summary>
        /// Sets the error message.
        /// </summary>
        /// <param name="messageList">The message list.</param>
        public void SetErrorMessage(IEnumerable<string> messageList)
        {
            foreach (var msg in messageList)
            {
                SetErrorMessage(msg);
            }
        }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return GetMessage("error");
        }

        /// <summary>
        /// Gets all error message.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllErrorMessage()
        {
            return GetAllMessage("error");
        }

        /// <summary>
        /// Sets the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetWarningMessage(string message)
        {
            SetMessage(message, "warning");
        }

        /// <summary>
        /// Sets the warning message.
        /// </summary>
        /// <param name="messageList">The message list.</param>
        public void SetWarningMessage(IEnumerable<string> messageList)
        {
            foreach (var msg in messageList)
            {
                SetWarningMessage(msg);
            }
        }

        /// <summary>
        /// Gets the warning message.
        /// </summary>
        /// <returns></returns>
        public string GetWarningMessage()
        {
            return GetMessage("warning");
        }

        /// <summary>
        /// Gets all warning message.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllWarningMessage()
        {
            return GetAllMessage("warning");
        }

        /// <summary>
        /// Sets the information message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SetInfoMessage(string message)
        {
            SetMessage(message, "info");
        }

        /// <summary>
        /// Sets the information message.
        /// </summary>
        /// <param name="messageList">The message list.</param>
        public void SetInfoMessage(IEnumerable<string> messageList)
        {
            foreach (var msg in messageList)
            {
                SetInfoMessage(msg);
            }
        }

        /// <summary>
        /// Gets the information message.
        /// </summary>
        /// <returns></returns>
        public string GetInfoMessage()
        {
            return GetMessage("info");
        }

        /// <summary>
        /// Gets all information message.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllInfoMessage()
        {
            return GetAllMessage("info");
        }

        /// <summary>
        /// Sets the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="flag">The flag.</param>
        private void SetMessage(string message, string flag)
        {
            Message[flag].Add(message);
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <param name="flag">The flag.</param>
        /// <returns></returns>
        private string GetMessage(string flag)
        {
            var message = Message[flag].Count != 0
                            ? Message[flag][0]
                            : String.Empty;

            return message;
        }

        /// <summary>
        /// Gets all message.
        /// </summary>
        /// <param name="flag">The flag.</param>
        /// <returns></returns>
        private List<string> GetAllMessage(string flag)
        {
            return Message[flag];
        }
    }
}
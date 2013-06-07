using System;
using System.Collections.Generic;

namespace MvcApp.AjaxResponses
{
    [Serializable]
    public class DefaultAjaxResponse
    {
        public List<Feedback> feedback = new List<Feedback>();

        public void AddFeedback(AjaxResponseStatusType status, string message)
        {
            if (message.Trim().Length > 0)
            {
                this.feedback.Add(new Feedback { status = status, message = message });
            }
        }

        public class Feedback
        {
            public AjaxResponseStatusType status;
            public string message;
        }

        public enum AjaxResponseStatusType
        {
            Error = -1,
            Success = 0,
            Warning = 1
        }

    }

}
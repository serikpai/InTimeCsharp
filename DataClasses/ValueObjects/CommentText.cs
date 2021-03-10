using System;

namespace InTime.CrossCutting.DataClasses.ValueObjects
{
    public class CommentText
    {
        private readonly string _text;

        private CommentText(string text)
        {
            _text = text;
        }

        public static implicit operator CommentText(string text)
        {
            return new CommentText(text);
        }
    }
}
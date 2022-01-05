namespace Training.Command.Undoable
{
    class HtmlDocument
    {
        public string Content { get; set; }

        public void Bold()
        {
            Content += "<b>";
        }
    }
}

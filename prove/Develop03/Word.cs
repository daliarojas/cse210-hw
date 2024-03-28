namespace Scripture
{
    public class Word
    {
        public string Text { get; set; }
        public bool Hidden { get; set; }

        public Word(string text)
        {
            Text = text;
            Hidden = false;
        }
    }
}
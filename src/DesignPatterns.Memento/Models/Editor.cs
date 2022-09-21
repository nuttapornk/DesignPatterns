using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Models
{
    public class Editor
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public int FontSize { get; set; }

        public string FontFace { get; set; }

        public Editor(string title,string text,int fontSize,string fontFace)
        {
            this.Title = title;
            this.Text = text;
            this.FontSize = fontSize;
            this.FontFace = fontFace;
        }

        public Memento<Editor> GetState()
        {
            return new Memento<Editor>(this);
        }

        public void SetState(Memento<Editor> memento)
        {
            Title = memento.Object.Title;
            Text = memento.Object.Text; 
            FontSize = memento.Object.FontSize;
            FontFace = memento.Object.FontFace;
        }

        public override string ToString()
        {
            return $"Title={Title},Text={Text},FontSize={FontSize},FontFace={FontFace}";
        }
    }
}

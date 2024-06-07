using System.ComponentModel.DataAnnotations;
using System.Drawing.Imaging;
using System.Text.Json.Serialization;

namespace PowerAutomation.Models
{
    public class ApplicationInformation
    {
        [Required]
        public string @Class { get; set; } = string.Empty;

        [Required]
        public string icon { get; set; } = @"AAABAAEAKDsCAAEAAQDgAwAAFgAAACgAAAAoAAAAdgAAAAEAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACxgZwAAAAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP/4f///AAAA//h///8AAAD/+H///wAAAP/4f///AAAA//h///8AAAD//////wAAAP//////AAAA//////8AAAD/+H///wAAAP/4f///AAAA//h///8AAAD/+H///wAAAP/4f///AAAA//h///8AAAD//D///wAAAP/8H///AAAA//4P//8AAAD//wf//wAAAP//g///AAAA///B//8AAAD//+H//wAAAP//8P//AAAA///w//8AAAD///D//wAAAP9/8P//AAAA/z/g//8AAAD/D8H//wAAAP8AA///AAAA/4AH//8AAAD/8B///wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD/+H///wAAAP/4f///AAAA//h///8AAAD/+H///wAAAP/4f///AAAA//////8AAAD//////wAAAP//////AAAA//h///8AAAD/+H///wAAAP/4f///AAAA//h///8AAAD/+H///wAAAP/4f///AAAA//w///8AAAD//B///wAAAP/+D///AAAA//8H//8AAAD//4P//wAAAP//wf//AAAA///h//8AAAD///D//wAAAP//8P//AAAA///w//8AAAD/f/D//wAAAP8/4P//AAAA/w/B//8AAAD/AAP//wAAAP+AB///AAAA//Af//8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA//////8AAAD//////wAAAP//////AAAA";

        [JsonIgnore]
        public Bitmap Icon
        {
            get
            {
                var bytes = Convert.FromBase64String(icon);
                using (var stream = new MemoryStream(bytes))
                {
                    stream.Flush();
                    stream.Position = 0;
                    return new Bitmap(stream);
                }
            }
            set
            {
                using (var stream = new MemoryStream())
                {
                    value.Save(stream, ImageFormat.Png);
                    stream.Flush();
                    stream.Position = 0;
                    icon = Convert.ToBase64String(stream.ToArray());
                }
            }
        }

        [Required]
        public string Titlebar { get; set; } = string.Empty;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoremIpsumWeb.Controllers
{
    public class AjaxController : Controller
    {
        private static string loremIpsumText =
@"Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.
Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.
Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.
Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis.
At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  At accusam aliquyam diam diam dolore dolores duo eirmod eos erat, et nonumy sed tempor et et invidunt justo labore Stet clita ea et gubergren, kasd magna no rebum. sanctus sea sed takimata ut vero voluptua. est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat. 
Consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";

        private static int anzahlBuchstaben = loremIpsumText.Count();
        private static int anzahlWoerter = loremIpsumText.
            Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Count();
        private static int anzahlAbsaetze = loremIpsumText
            .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            .Count();

        public ActionResult LoremIpsum(string itemtyp, int number)
        {
            string dataToTransmit = "Ungültige Eingabe";

            switch (itemtyp)
            {
                case "Buchstabe":
                    dataToTransmit = GetBuchstabe(number);
                    break;
                case "Wort":
                    dataToTransmit = GetWoerter(number);
                    break;
                case "Absatz":
                    dataToTransmit = GetAbsaetze(number);
                    break;
                default:
                    break;
            }

            return Json(dataToTransmit.Trim());
        }
        private string GetBuchstabe(int number)
        {
            string data = string.Empty;

            while (number > 0)
            {
                if (number >= anzahlBuchstaben)
                {
                    data = string.Format("{0}{1}{2}", data, Environment.NewLine, loremIpsumText);
                    number -= anzahlBuchstaben;
                }
                else
                {
                    data = string.Format("{0}{1}{2}", data, Environment.NewLine, string.Join(string.Empty, loremIpsumText.Take(number)));
                    number -= number;
                }
            }

            return data;
        }
        private string GetWoerter(int number)
        {
            string data = string.Empty;

            while (number > 0)
            {
                if (number >= anzahlWoerter)
                {
                    data = string.Format("{0}{1}{2}", data, Environment.NewLine, loremIpsumText);
                    number -= anzahlWoerter;
                }
                else
                {
                    data = string.Format("{0}{1}{2}", data, Environment.NewLine, 
                        string.Join(" ", 
                            loremIpsumText
                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Take(number)
                        )); 
                    number -= number;
                }
            }

            return data;
        }
        private string GetAbsaetze(int number)
        {
            string data = string.Empty;

            while (number > 0)
            {
                if (number >= anzahlAbsaetze)
                {
                    data = string.Format("{0}{1}{2}", data, Environment.NewLine, loremIpsumText);
                    number -= anzahlAbsaetze;
                }
                else
                {
                    data = string.Format("{0}{1}{2}",
                        data,
                        Environment.NewLine,
                        string.Join(Environment.NewLine, 
                            loremIpsumText
                                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                .Take(number))
                        ); 
                    number -= anzahlAbsaetze;
                }
            }

            return data;
        }
    }
}

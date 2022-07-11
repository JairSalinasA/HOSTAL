using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTATION.Helpers
{
    public class Temas
    {
        public static Color panelMenu;
        public static Color panelBuscar;
        public static Color panelDesktop;
        public static Color fuenteA;
        public static Color fuenteB;

        //Tema Obscuro
        private static readonly Color panelMenuO = Color.FromArgb(10, 10, 10);
        private static readonly Color panelBuscarO = Color.FromArgb(10, 10, 10);
        private static readonly Color panelDesktopO = Color.FromArgb(31, 31, 31);
        private static readonly Color fuenteAO = Color.White;
        private static readonly Color fuenteBO = Color.Silver;
        //Tema Claro
        private static readonly Color panelMenuC = Color.FromArgb(235,235,235);
        private static readonly Color panelBuscarC = Color.FromArgb(70,71,117);
        private static readonly Color panelDesktopC = Color.FromArgb(10, 10, 10);
        private static readonly Color fuenteAC = Color.FromArgb(36,36,36);
        private static readonly Color fuenteBC = Color.FromArgb(60,60,60);

        public static void ElegirTema(string Tema)
        {
            if (Tema=="Obscuro")
            {
               panelMenu = panelMenuO;
               panelBuscar=panelBuscarO;
               panelDesktop=panelDesktopO;
               fuenteA=fuenteAO;
               fuenteB= fuenteBO;
            }
            if (Tema == "Claro")
            {
                panelMenu = panelMenuC;
                panelBuscar = panelBuscarC;
                panelDesktop = panelDesktopC;
                fuenteA = fuenteAC;
                fuenteB = fuenteBC;
            }
        }
    }
}

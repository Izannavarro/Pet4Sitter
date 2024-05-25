using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter.Clases
{

    /// <summary>
    /// Clase BufferedFlowLayoutPanel que hereda de FlowLayoutPanel.
    /// Esta clase está diseñada para mejorar el rendimiento gráfico y reducir el parpadeo (flickering)
    /// durante la repintura del control mediante el uso de técnicas de doble búfer y estilos de control optimizados.
    /// </summary>
    public class BufferedFlowLayoutPanel : FlowLayoutPanel
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BufferedFlowLayoutPanel"/>.
        /// </summary>
        public BufferedFlowLayoutPanel()
        {
            // Habilita el doble búfer para el control.
            this.DoubleBuffered = true;

            // Configura el control para usar un búfer optimizado.
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Configura el control para evitar que se genere un evento de pintura adicional
            // antes de que se dibuje el control, reduciendo el parpadeo.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // Aplica los estilos configurados al control.
            this.UpdateStyles();
        }
    }
}

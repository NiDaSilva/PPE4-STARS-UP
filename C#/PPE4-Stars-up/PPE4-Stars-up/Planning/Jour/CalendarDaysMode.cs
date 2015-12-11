using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    /// <summary>
    /// Enumerates the possible modes of the days visualization on the <see cref="Calendar"/>
    /// </summary>
    public enum CalendarDaysMode
    {
        /// <summary>
        /// A short version of the day is visible without time scale.
        /// </summary>
        Short,

        /// <summary>
        /// The day is fully visible with time scale.
        /// </summary>
        Expanded
    }
}

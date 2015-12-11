using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    /// <summary>
    /// Possible alignment for <see cref="CalendarItem"/> images
    /// </summary>
    public enum CalendarItemImageAlign
    {
        /// <summary>
        /// Image is drawn at north of text
        /// </summary>
        North,

        /// <summary>
        /// Image is drawn at south of text
        /// </summary>
        South,

        /// <summary>
        /// Image is drawn at east of text
        /// </summary>
        East,

        /// <summary>
        /// Image is drawn at west of text
        /// </summary>
        West,
    }
}

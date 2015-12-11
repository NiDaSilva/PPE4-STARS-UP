using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    /// <summary>
    /// Interface implemented by every selectable element of the calendar
    /// </summary>
    public interface ICalendarSelectableElement
        : ISelectableElement, IComparable<ICalendarSelectableElement>
    {

        /// <summary>
        /// Gets the calendar this element belongs to
        /// </summary>
        Calendar Calendar { get; }

        /// <summary>
        /// Gets the calendar
        /// </summary>
        DateTime Date { get; }

    }
}

using System.Collections;

namespace Lesson01
{
    class MonthsCollection
    {
        readonly Month[] month = {
                                    new Month("January", 1, 31),
                                    new Month("February", 2, 28),
                                    new Month("March", 3, 31),
                                    new Month("April", 4, 30),
                                    new Month("May", 5, 31),
                                    new Month("June", 6, 30),
                                    new Month("July", 7, 31),
                                    new Month("August", 8, 31),
                                    new Month("September", 9, 30),
                                    new Month("October", 10, 31),
                                    new Month("November", 11, 30),
                                    new Month("December", 12, 31)
                                };

        public IEnumerator GetEnumerator() => month.GetEnumerator();
    }
}

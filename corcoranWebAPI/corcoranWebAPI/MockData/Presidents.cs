using System;
using System.Collections.Generic;
using corcoranWebAPI.Model;

namespace corcoranWebAPI.MockData
{
    public class Presidents
    {
        public IEnumerable<President> presidents()
        {
            List<President> presidents = new List<President>
                {
                    new President{president="George Washington",birthday="1732-2-22",birthplace="Westmoreland Co., Va.",death_day="1799-12-14",death_place="Mount Vernon, Va."},
                    new President{president="John Adams",birthday="1735-10-30",birthplace="Quincy, Mass.",death_day="1826-7-4",death_place="Quincy, Mass."},
                    new President{president="Thomas Jefferson",birthday="1743-4-13",birthplace="Albemarle Co., Va.",death_day="1826-7-4",death_place="Albemarle Co., Va."},
                    new President{president="James Madison",birthday="1751-3-16",birthplace="Port Conway, Va.",death_day="1836-6-28",death_place="Orange Co., Va."},
                    new President{president="James Monroe",birthday="1758-4-28",birthplace="Westmoreland Co., Va.",death_day="1831-7-4",death_place="New York, New York"},
                    new President{president="John Quincy Adams",birthday="1767-7-11",birthplace="Quincy, Mass.",death_day="1848-2-23",death_place="Washington, D.C."},
                    new President{president="Andrew Jackson",birthday="1767-3-15",birthplace="Waxhaws, No./So. Carolina",death_day="1845-6-8",death_place="Nashville, Tennessee"},
                    new President{president="Martin Van Buren",birthday="1782-12-5",birthplace="Kinderhook, New York",death_day="1862-7-24",death_place="Kinderhook, New York"},
                    new President{president="William Henry Harrison",birthday="1773-2-9",birthplace="Charles City Co., Va.",death_day="1841-4-4",death_place="Washington, D.C."},
                    new President{president="John Tyler",birthday="1790-3-29",birthplace="Charles City Co., Va.",death_day="1862-1-18",death_place="Richmond, Va."},
                    new President{president="James K. Polk",birthday="1795-11-2",birthplace="Mecklenburg Co., N.C.",death_day="1849-6-15",death_place="Nashville, Tennessee"},
                    new President{president="Zachary Taylor",birthday="1784-11-24",birthplace="Orange County, Va.",death_day="1850-7-9",death_place="Washington, D.C"},
                    new President{president="Millard Fillmore",birthday="1800-1-7",birthplace="Cayuga Co., New York",death_day="1874-3-8",death_place="Buffalo, New York"},
                    new President{president="Franklin Pierce",birthday="1804-11-23",birthplace="Hillsborough, N.H.",death_day="1869-10-8",death_place="Concord, New Hamp."},
                    new President{president="James Buchanan",birthday="1791-4-23",birthplace="Cove Gap, Pa.",death_day="1868-6-1",death_place="Lancaster, Pa."},
                    new President{president="Abraham Lincoln",birthday="1809-2-12",birthplace="LaRue Co., Kentucky",death_day="1865-4-15",death_place="Washington, D.C."},
                    new President{president="Andrew Johnson",birthday="1808-12-29",birthplace="Raleigh, North Carolina",death_day="1875-7-31",death_place="Elizabethton, Tenn."},
                    new President{president="Ulysses S. Grant",birthday="1822-4-27",birthplace="Point Pleasant, Ohio",death_day="1885-7-23",death_place="Wilton, New York"},
                    new President{president="Rutherford B. Hayes",birthday="1822-10-4",birthplace="Delaware, Ohio",death_day="1893-1-17",death_place="Fremont, Ohio"},
                    new President{president="James A. Garfield",birthday="1831-11-19",birthplace="Cuyahoga Co., Ohio",death_day="1881-9-19",death_place="Elberon, New Jersey"},
                    new President{president="Chester Arthur",birthday="1829-10-5",birthplace="Fairfield, Vermont",death_day="1886-11-18",death_place="New York, New York"},
                    new President{president="Grover Cleveland",birthday="1837-3-18",birthplace="Caldwell, New Jersey",death_day="1908-06-24",death_place="Princeton, New Jersey"},
                    new President{president="Benjamin Harrison",birthday="1833-8-20",birthplace="North Bend, Ohio",death_day="1901-03-13",death_place="Indianapolis, Indiana"},
                    new President{president="William McKinley",birthday="1843-1-29",birthplace="Niles, Ohio",death_day="1901-09-14",death_place="Buffalo, New York"},
                    new President{president="Theodore Roosevelt",birthday="1858-10-27",birthplace="New York, New York",death_day="1919-01-06",death_place="Oyster Bay, New York"},
                    new President{president="William Howard Taft",birthday="1857-9-15",birthplace="Cincinnati, Ohio",death_day="1930-03-08",death_place="Washington, D.C."},
                    new President{president="Woodrow Wilson",birthday="1856-12-28",birthplace="Staunton, Virginia",death_day="1924-02-03",death_place="Washington, D.C."},
                    new President{president="Warren G. Harding",birthday="1865-11-2",birthplace="Morrow County, Ohio",death_day="1923-08-02",death_place="San Francisco, Cal."},
                    new President{president="Calvin Coolidge",birthday="1872-7-4",birthplace="Plymouth, Vermont",death_day="1933-01-05",death_place="Northampton, Mass."},
                    new President{president="Herbert Hoover",birthday="1874-8-10",birthplace="West Branch, Iowa",death_day="1964-10-20",death_place="New York, New York"},
                    new President{president="Franklin Roosevelt",birthday="1882-1-30",birthplace="Hyde Park, New York",death_day="1945-04-12",death_place="Warm Springs, Georgia"},
                    new President{president="Harry S. Truman",birthday="1884-5-8",birthplace="Lamar, Missouri",death_day="1972-12-26",death_place="Kansas City, Missouri"},
                    new President{president="Dwight Eisenhower",birthday="1890-10-14",birthplace="Denison, Texas",death_day="1969-03-28",death_place="Washington, D.C."},
                    new President{president="John F. Kennedy",birthday="1917-05-29",birthplace="Brookline, Mass.",death_day="1963-11-22",death_place="Dallas, Texas"},
                    new President{president="Lyndon B. Johnson",birthday="1908-08-27",birthplace="Gillespie Co., Texas",death_day="1973-01-22",death_place="Gillespie Co., Texas"},
                    new President{president="Richard Nixon",birthday="1913-01-09",birthplace="Yorba Linda, Cal.",death_day="1994-04-22",death_place="New York, New York"},
                    new President{president="Gerald Ford",birthday="1913-07-14",birthplace="Omaha, Nebraska",death_day="2006-12-26",death_place="Rancho Mirage, Cal."},
                    new President{president="Jimmy Carter",birthday="1924-10-01",birthplace="Plains, Georgia",death_day="1900-01-00",death_place=""},
                    new President{president="Ronald Reagan",birthday="1911-02-06",birthplace="Tampico, Illinois",death_day="2004-06-05",death_place="Los Angeles, Cal."},
                    new President{president="George Bush",birthday="1924-06-12",birthplace="Milton, Mass.",death_day="1900-01-00",death_place=""},
                    new President{president="Bill Clinton",birthday="1946-08-19",birthplace="Hope, Arkansas",death_day="1900-01-00",death_place=""},
                    new President{president="George W. Bush",birthday="1646-7-6",birthplace="New Haven, Conn.",death_day="1900-01-00",death_place=""},
                    new President{president="Barack Obama",birthday="1961-08-04",birthplace="Honolulu, Hawaii",death_day="1900-01-00",death_place=""},
                    new President{president="Donald Trump",birthday="1946-06-14",birthplace="New York, New York",death_day="1900-01-00",death_place=""}

                };
            return presidents;
        }
    }
}

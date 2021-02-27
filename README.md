# TimeLocalization - C#

The library for convert datetime to time ago in c#


Inspiration [Github](https://github.com/NickStrupat/TimeAgo)

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
    - [TimeAgo](#timeago)
- [Format Supported](#format)
- [Languages supported](#languages)


## Installation <a name="installation"></a>

NuGet package listed on [nuget.org](https://www.nuget.org/packages/TimeLocalization)

    Install-Package TimeLocalization -Version 1.0.2
or
    
    dotnet add package TimeLocalization --version 1.0.2

## Usage <a name="usage"></a>

### TimeAgo <a name="timeago"></a>

    var dateTime = DateTime.UtcNow;
    var culture = new CultureInfo("th-TH");
    
    dateTime.AsTimeAgo(); // just now
    dateTime.AsTimeAgo(DateTime.UtcNow.AddMinutes(9)) // 9 minutes ago
    dateTime.AsTimeAgo(DateTime.UtcNow.AddMinutes(9), culture) // 9 นาทีที่แล้ว


## Format Supported <a name="format"></a>

- just now
- 5 seconds ago
- 1 minute ago
- 9 minutes ago
- 1 hour ago
- 23 hours ago
- 1 days ago
- 3 days ago
- 1 week ago
- 2 weeks ago
- 1 month ago
- 11 months ago
- 1 year ago
- 2 years ago
- a while
- in 4 seconds
- in 1 minute
- in 8 minutes
- in 1 hour
- in 23 hours
- in 1 day
- in 2 days
- in 1 week
- in 2 weeks
- in 1 month
- in 11 months
- in 1 year
- in 2 years


## Languages supported <a name="languages"></a>

- Basque
- Bulgarian
- Catalan
- Danish
- German
- Greek
- Japan
- English
- Spanish
- Thai


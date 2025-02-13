using System;

namespace GitHubUserActivity.Utils;

public class AdjustTimeZone {

    public static string FormatDate(DateTime date){

        return date.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss");
    }
}
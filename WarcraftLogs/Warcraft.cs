using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarcraftLogs.Helpers;

namespace WarcraftLogs
{
    public class Warcraft
    {
        private const string WARCRAFTLOGSBASEURL = "https://www.warcraftlogs.com/v1";
        private const string API_PARAMETER = "api_key";
        private HTTPHelper _httpHelper { get; }
        private string apikey { get; }

        public Warcraft(string APIKey)
        {
            apikey = APIKey;
            _httpHelper = new HTTPHelper();
        }

        public List<DTO.Zones.Zones> getZones()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/zones");
            List<DTO.Zones.Zones> zones = _httpHelper.Get<List<DTO.Zones.Zones>>(url, parameters);
            return zones;
        }

        public List<DTO.Classes.Classes> getClasses()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/classes");
            List<DTO.Classes.Classes> classes = _httpHelper.Get<List<DTO.Classes.Classes>>(url, parameters);
            return classes;
        }

        public DTO.Rankings.Encounter getEncounter(int encounterID)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/rankings/encounter/{encounterID}");
            DTO.Rankings.Encounter encounter = _httpHelper.Get<DTO.Rankings.Encounter>(url, parameters);
            return encounter;
        }

        public DTO.Rankings.Encounter getEncounter(int encounterID, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/rankings/encounter/{encounterID}");
            DTO.Rankings.Encounter encounter = _httpHelper.Get<DTO.Rankings.Encounter>(url, parameters);
            return encounter;
        }

        public List<DTO.Rankings.Character> getRankingsCharacter(string characterName, string serverName, string serverRegion)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/rankings/character/{characterName}/{serverName}/{serverRegion}");
            List<DTO.Rankings.Character> character = _httpHelper.Get<List<DTO.Rankings.Character>>(url, parameters);
            return character;
        }

        public List<DTO.Rankings.Character> getRankingsCharacter(string characterName, string serverName, string serverRegion, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/rankings/character/{characterName}/{serverName}/{serverRegion}");
            List<DTO.Rankings.Character> character = _httpHelper.Get<List<DTO.Rankings.Character>>(url, parameters);
            return character;
        }

        public List<DTO.Parses.Character> getParsesCharacter(string characterName, string serverName, string serverRegion)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/parses/character/{characterName}/{serverName}/{serverRegion}");
            List<DTO.Parses.Character> character = _httpHelper.Get<List<DTO.Parses.Character>>(url, parameters);
            return character;
        }

        public List<DTO.Parses.Character> getParsesCharacter(string characterName, string serverName, string serverRegion, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/parses/character/{characterName}/{serverName}/{serverRegion}");
            List<DTO.Parses.Character> character = _httpHelper.Get<List<DTO.Parses.Character>>(url, parameters);
            return character;
        }

        public List<DTO.Reports.Guild> getReportsGuild(string guildName, string serverName, string serverRegion)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/reports/guild/{guildName}/{serverName}/{serverRegion}");
            List<DTO.Reports.Guild> guild = _httpHelper.Get<List<DTO.Reports.Guild>>(url, parameters);
            return guild;
        }

        public List<DTO.Reports.Guild> getReportsGuild(string guildName, string serverName, string serverRegion, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/reports/guild/{guildName}/{serverName}/{serverRegion}");
            List<DTO.Reports.Guild> guild = _httpHelper.Get<List<DTO.Reports.Guild>>(url, parameters);
            return guild;
        }

        public List<DTO.Reports.User> getReportsUser(string userName)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/reports/user/{userName}");
            List<DTO.Reports.User> user = _httpHelper.Get<List<DTO.Reports.User>>(url, parameters);
            return user;
        }

        public List<DTO.Reports.User> getReportsUser(string userName, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/reports/user/{userName}");
            List<DTO.Reports.User> user = _httpHelper.Get<List<DTO.Reports.User>>(url, parameters);
            return user;
        }

        public List<DTO.Report.Fights> getReportFights(string code)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/fights/{code}");
            List<DTO.Report.Fights> fights = _httpHelper.Get<List<DTO.Report.Fights>>(url, parameters);
            return fights;
        }

        public List<DTO.Report.Fights> getReportFights(string code, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/fights/{code}");
            List<DTO.Report.Fights> fights = _httpHelper.Get<List<DTO.Report.Fights>>(url, parameters);
            return fights;
        }

        public List<DTO.Report.Events> getReportEvents(string code)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/events/{code}");
            List<DTO.Report.Events> events = _httpHelper.Get<List<DTO.Report.Events>>(url, parameters);
            return events;
        }

        public List<DTO.Report.Events> getReportEvents(string code, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/events/{code}");
            List<DTO.Report.Events> events = _httpHelper.Get<List<DTO.Report.Events>>(url, parameters);
            return events;
        }

        public List<DTO.Report.Tables> getReportTables(string view, string code)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add(API_PARAMETER, apikey);
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/tables/{view}/{code}");
            List<DTO.Report.Tables> tables = _httpHelper.Get<List<DTO.Report.Tables>>(url, parameters);
            return tables;
        }

        public List<DTO.Report.Tables> getReportTables(string view, string code, Dictionary<string, string> parameters)
        {
            if (parameters != null)
                parameters.Add(API_PARAMETER, apikey);
            else
            {
                parameters = new Dictionary<string, string>();
                parameters.Add(API_PARAMETER, apikey);
            }
            Uri url = new Uri($"{WARCRAFTLOGSBASEURL}/report/tables/{view}/{code}");
            List<DTO.Report.Tables> tables = _httpHelper.Get<List<DTO.Report.Tables>>(url, parameters);
            return tables;
        }
    }
}

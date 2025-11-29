namespace BlazorServer.Modals
{
    public static class MyDatabase
    {
        #region Sample List of Servers
        private static List<Server> Servers = new List<Server>
        {
            new Server(){ ServerId = 1  , ServerName = "سرور هلند 1"        , ServerCountry = "هلند"          , ServerIsOnline = true  },
            new Server(){ ServerId = 2  , ServerName = "سرور هلند 2"        , ServerCountry = "هلند"          , ServerIsOnline = false },
            new Server(){ ServerId = 3  , ServerName = "سرور ایران 1"       , ServerCountry = "ایران"         , ServerIsOnline = true  },
            new Server(){ ServerId = 4  , ServerName = "سرور ایران 2"       , ServerCountry = "ایران"         , ServerIsOnline = false },
            new Server(){ ServerId = 5  , ServerName = "سرور آلمان 1"       , ServerCountry = "آلمان"         , ServerIsOnline = true  },
            new Server(){ ServerId = 6  , ServerName = "سرور آلمان 2"       , ServerCountry = "آلمان"         , ServerIsOnline = false },
            new Server(){ ServerId = 7  , ServerName = "سرور فرانسه 1"      , ServerCountry = "فرانسه"        , ServerIsOnline = true  },
            new Server(){ ServerId = 8  , ServerName = "سرور فرانسه 2"      , ServerCountry = "فرانسه"        , ServerIsOnline = false },
            new Server(){ ServerId = 9  , ServerName = "سرور آمریکا 1"      , ServerCountry = "آمریکا"        , ServerIsOnline = true  },
            new Server(){ ServerId = 10 , ServerName = "سرور آمریکا 2"      , ServerCountry = "آمریکا"        , ServerIsOnline = false },
            new Server(){ ServerId = 11 , ServerName = "سرور انگلیس 1"      , ServerCountry = "انگلیس"        , ServerIsOnline = true  },
            new Server(){ ServerId = 12 , ServerName = "سرور انگلیس 2"      , ServerCountry = "انگلیس"        , ServerIsOnline = false },
            new Server(){ ServerId = 13 , ServerName = "سرور کانادا 1"      , ServerCountry = "کانادا"        , ServerIsOnline = true  },
            new Server(){ ServerId = 14 , ServerName = "سرور کانادا 2"      , ServerCountry = "کانادا"        , ServerIsOnline = false },
            new Server(){ ServerId = 15 , ServerName = "سرور ترکیه 1"       , ServerCountry = "ترکیه"         , ServerIsOnline = true  },
            new Server(){ ServerId = 16 , ServerName = "سرور ترکیه 2"       , ServerCountry = "ترکیه"         , ServerIsOnline = false },
            new Server(){ ServerId = 17 , ServerName = "سرور امارات 1"      , ServerCountry = "امارات"        , ServerIsOnline = true  },
            new Server(){ ServerId = 18 , ServerName = "سرور امارات 2"      , ServerCountry = "امارات"        , ServerIsOnline = false },
            new Server(){ ServerId = 19 , ServerName = "سرور قطر 1"         , ServerCountry = "قطر"           , ServerIsOnline = true  },
            new Server(){ ServerId = 20 , ServerName = "سرور قطر 2"         , ServerCountry = "قطر"           , ServerIsOnline = false },
            new Server(){ ServerId = 21 , ServerName = "سرور ایتالیا 1"     , ServerCountry = "ایتالیا"       , ServerIsOnline = true  },
            new Server(){ ServerId = 22 , ServerName = "سرور ایتالیا 2"     , ServerCountry = "ایتالیا"       , ServerIsOnline = false },
            new Server(){ ServerId = 23 , ServerName = "سرور اسپانیا 1"     , ServerCountry = "اسپانیا"       , ServerIsOnline = true  },
            new Server(){ ServerId = 24 , ServerName = "سرور اسپانیا 2"     , ServerCountry = "اسپانیا"       , ServerIsOnline = false },
            new Server(){ ServerId = 25 , ServerName = "سرور سوئیس 1"       , ServerCountry = "سوئیس"         , ServerIsOnline = true  },
            new Server(){ ServerId = 26 , ServerName = "سرور سوئیس 2"       , ServerCountry = "سوئیس"         , ServerIsOnline = false },
            new Server(){ ServerId = 27 , ServerName = "سرور سوئد 1"        , ServerCountry = "سوئد"          , ServerIsOnline = true  },
            new Server(){ ServerId = 28 , ServerName = "سرور سوئد 2"        , ServerCountry = "سوئد"          , ServerIsOnline = false },
            new Server(){ ServerId = 29 , ServerName = "سرور نروژ 1"        , ServerCountry = "نروژ"          , ServerIsOnline = true  },
            new Server(){ ServerId = 30 , ServerName = "سرور نروژ 2"        , ServerCountry = "نروژ"          , ServerIsOnline = false },
            new Server(){ ServerId = 31 , ServerName = "سرور دانمارک 1"     , ServerCountry = "دانمارک"       , ServerIsOnline = true  },
            new Server(){ ServerId = 32 , ServerName = "سرور دانمارک 2"     , ServerCountry = "دانمارک"       , ServerIsOnline = false },
            new Server(){ ServerId = 33 , ServerName = "سرور فنلاند 1"      , ServerCountry = "فنلاند"        , ServerIsOnline = true  },
            new Server(){ ServerId = 34 , ServerName = "سرور فنلاند 2"      , ServerCountry = "فنلاند"        , ServerIsOnline = false },
            new Server(){ ServerId = 35 , ServerName = "سرور روسیه 1"       , ServerCountry = "روسیه"         , ServerIsOnline = true  },
            new Server(){ ServerId = 36 , ServerName = "سرور روسیه 2"       , ServerCountry = "روسیه"         , ServerIsOnline = false },
            new Server(){ ServerId = 37 , ServerName = "سرور چین 1"         , ServerCountry = "چین"           , ServerIsOnline = true  },
            new Server(){ ServerId = 38 , ServerName = "سرور چین 2"         , ServerCountry = "چین"           , ServerIsOnline = false },
            new Server(){ ServerId = 39 , ServerName = "سرور ژاپن 1"        , ServerCountry = "ژاپن"          , ServerIsOnline = true  },
            new Server(){ ServerId = 40 , ServerName = "سرور ژاپن 2"        , ServerCountry = "ژاپن"          , ServerIsOnline = false },
            new Server(){ ServerId = 41 , ServerName = "سرور کره جنوبی 1"   , ServerCountry = "کره جنوبی"     , ServerIsOnline = true  },
            new Server(){ ServerId = 42 , ServerName = "سرور کره جنوبی 2"   , ServerCountry = "کره جنوبی"     , ServerIsOnline = false },
            new Server(){ ServerId = 43 , ServerName = "سرور هند 1"         , ServerCountry = "هند"           , ServerIsOnline = true  },
            new Server(){ ServerId = 44 , ServerName = "سرور هند 2"         , ServerCountry = "هند"           , ServerIsOnline = false },
            new Server(){ ServerId = 45 , ServerName = "سرور برزیل 1"       , ServerCountry = "برزیل"         , ServerIsOnline = true  },
            new Server(){ ServerId = 46 , ServerName = "سرور برزیل 2"       , ServerCountry = "برزیل"         , ServerIsOnline = false },
            new Server(){ ServerId = 47 , ServerName = "سرور استرالیا 1"    , ServerCountry = "استرالیا"      , ServerIsOnline = true  },
            new Server(){ ServerId = 48 , ServerName = "سرور استرالیا 2"    , ServerCountry = "استرالیا"      , ServerIsOnline = false },
            new Server(){ ServerId = 49 , ServerName = "سرور آفریقای جنوبی 1", ServerCountry = "آفریقای جنوبی", ServerIsOnline = true  },
            new Server(){ ServerId = 50 , ServerName = "سرور آفریقای جنوبی 2", ServerCountry = "آفریقای جنوبی", ServerIsOnline = false }
        };
        #endregion

        public static void AddServer(Server server)
        {
            server.ServerId = Servers.Max(s => s.ServerId) + 1;
            Servers.Add(server);
        }

        public static List<Server> GetAllServers()
        {
            return Servers;
        }
        public static Server GetServerById(int serverId)
        {
            return Servers.FirstOrDefault(s => s.ServerId == serverId);
        }
        public static void UpdateServer(int id, Server updatedServer)
        {
            if (id != updatedServer.ServerId)
            {
                return;
            }
            var server = GetServerById(id);
            if (server != null)
            {
                server.ServerName = updatedServer.ServerName;
                server.ServerCountry = updatedServer.ServerCountry;
                server.ServerIsOnline = updatedServer.ServerIsOnline;
            }
        }
        public static void DeleteServer(int serverId)
        {
            var serverDelete = GetServerById(serverId);
            if (serverDelete != null)
            {
                Servers.Remove(serverDelete);
            }
        }
    }
}

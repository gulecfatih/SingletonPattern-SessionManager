using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_SingletonPattern_SessionManager.Manager
{
    public class SessionManager
    {
        private static SessionManager _instance;
        private string _sessionId;
        private bool _sessionStarted;

        private SessionManager()
        {
            _sessionStarted = false; // Oturum başlatılmadı
        }

        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SessionManager();
                }
                return _instance;
            }
        }

        public string GetSessionId()
        {
            return _sessionId;
        }

        public bool IsSessionStarted()
        {
            return _sessionStarted; // Oturumun başlatılıp başlatılmadığını kontrol et
        }

        public void StartSession()
        {
            _sessionId = Guid.NewGuid().ToString(); // Yeni bir oturum başlat
            _sessionStarted = true; // Oturum başlatıldı
        }
        public void SignOut()
        {
            _sessionId = string.Empty;
            _sessionStarted = false;
        }

    }

}

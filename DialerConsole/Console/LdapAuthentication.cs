using System;
using System.DirectoryServices.Protocols;
using System.Globalization;
using System.Net;
using System.Security.Permissions;

namespace Console
{
    public class LdapAuthentication
    {
        public string HostName { get; private set; }
        public string BaseDn { get; set; }
        public string Filter { get; set; }

        public LdapAuthentication(string hostName, string baseDn, string filter)
        {
            this.HostName = hostName;
            this.BaseDn = baseDn;
            this.Filter = filter;
        }

        [SecurityPermission(SecurityAction.Demand)]
        public bool Authenticate(string userName, string password)
        {
            using (var ldap = new LdapConnection(new LdapDirectoryIdentifier(this.HostName)))
            {
                ldap.SessionOptions.ProtocolVersion = 3;
                ldap.SessionOptions.VerifyServerCertificate = new VerifyServerCertificateCallback((con, cer) => true);

                ldap.AuthType = AuthType.Basic;
                ldap.Credential = new NetworkCredential("lbvdc\\sysauth", "frusPa&7Wr");
                ldap.Bind();

                var dn = GetDn(ldap, userName);

                if (dn == null)
                    // Usuário inexistente.
                    return false;

                try
                {
                    ldap.AuthType = AuthType.Basic;
                    ldap.Bind(new NetworkCredential(dn, password));

                    return true;
                }
                catch (DirectoryOperationException)
                {
                    // Usuário inativo.
                    return false;
                }
                catch (LdapException)
                {
                    // Senha incorreta.
                    return false;
                }
            }
        }

        private String GetDn(LdapConnection ldap, String userName)
        {
            var request = new SearchRequest(this.BaseDn, string.Format(CultureInfo.InvariantCulture, this.Filter, userName), SearchScope.Subtree);
            var response = (SearchResponse)ldap.SendRequest(request);

            if (response.Entries.Count == 1)
                return response.Entries[0].DistinguishedName;

            return null;
        }
    }
}

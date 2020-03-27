using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DataCollection.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DataCollection.Models
{
    public class AdfsModel
    {
        // OS Radio Button (WS12R2, WS2016, WS2019))
        public string os { get; set; }

        // Target Server Check Box (AD FS, WAP)
        public bool tgtAdfs { get; set; }
        public bool tgtWap { get; set; }


        // Client Options Check Box (PSR, Fiddler, Netmon, Cert, Kerberos, netlogon)
        public bool cliPsr { get; set; }
        public bool cliFiddler { get; set; }
        public bool cliNetmon { get; set; }
        public bool cliCert { get; set; }
        public bool cliSch { get; set; }
        public bool cliKerb { get; set; }
        public bool cliNetlog { get; set; }


        // Server Options Check Box (AD FS Audit, AD FS Debug, Netmon, Schannel, CAPI2, Kerberos, netlogon)
        public bool srvAudit { get; set; }
        public bool srvDebug { get; set; }
        public bool srvNetmon { get; set; }
        public bool srvSch { get; set; }
        public bool srvCert { get; set; }
        public bool srvKerb { get; set; }
        public bool srvNetlog { get; set; }


        // Target (Clietnt Only / Servers Only)
        public bool isClientOnly { get; set; }
        public bool isServersOnly { get; set; }


        public void initialize()
        {
            // OS
            os = Constants.Adfs.OsWs16;

            // Server (ADFS,WAP)
            tgtAdfs = true;
            tgtWap = true;

            // Client Options
            cliPsr = true;
            cliFiddler = true;
            cliNetmon = false;
            cliSch = false;
            cliCert = false;
            cliKerb = false;
            cliNetlog = false;

            // Server Options
            srvAudit = true;
            srvDebug = false;
            srvNetmon = false;
            srvSch = false;
            srvCert = false;
            srvKerb = false;
            srvNetlog = false;

            setTarget();

        }

        public void setTarget()
        {
            if ((cliPsr || cliFiddler || cliNetmon || cliSch || cliCert || cliKerb || cliNetlog) && (!tgtAdfs && !tgtWap) )
            {
                isClientOnly = true;
            }
            else
            {
                isClientOnly = false;
            }
            
            if ((tgtAdfs || tgtWap) && (!cliPsr && !cliFiddler && !cliNetmon && !cliSch && !cliCert && !cliKerb && !cliNetlog))
            {
                isServersOnly = true;
            }
            else
            {
                isServersOnly = false;
            }
        }
    }
}

using gestionDette.ism.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDette.ism.Core.ServiceInstance
{
    public interface YamlServiceIns
    {
        Object GetInstanceClient(string repoType, string repoType2, ClientRepoListInt clientRepo);
        Object GetInstanceUser(string repoType, string repoType2, UserRepoListInt userRepo);
        Object GetInstanceArticle(string repoType, string repoType2, ArticleRepoListInt articleRepo);
        Object GetInstanceDemande(string repoType, string repoType2, DemandeRepoListInt demandeRepo);
        Object GetInstanceDetail(string repoType, string repoType2, DetailRepoListInt detailRepo);
        Object GetInstanceDette(string repoType, string repoType2, DetteRepoListInt detteRepo);
        Object GetInstancePaiement(string repoType, string repoType2, PaiementRepoListInt paiementRepo);
    }
}

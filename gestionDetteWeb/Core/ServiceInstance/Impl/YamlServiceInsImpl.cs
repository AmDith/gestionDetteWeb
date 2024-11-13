using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDette.ism.Core.Database;
using System;
using gestionDette.ism.Core.ServiceInstance;

namespace gestionDette.ism.Core.Repo.list.Impl
{
    public class YamlSericeInsImpl : YamlServiceIns
    {
        public object GetInstanceClient(string repoType, string repoType2, ClientRepoListInt clientRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(ClientRepoListInt) });
                        return constructor?.Invoke(new object[] { clientRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstanceUser(string repoType, string repoType2, UserRepoListInt userRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(UserRepoListInt) });
                        return constructor?.Invoke(new object[] { userRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstanceArticle(string repoType, string repoType2, ArticleRepoListInt articleRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(ArticleRepoListInt) });
                        return constructor?.Invoke(new object[] { articleRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstanceDemande(string repoType, string repoType2, DemandeRepoListInt demandeRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(DemandeRepoListInt) });
                        return constructor?.Invoke(new object[] { demandeRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstanceDetail(string repoType, string repoType2, DetailRepoListInt detailRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(DetailRepoListInt) });
                        return constructor?.Invoke(new object[] { detailRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstanceDette(string repoType, string repoType2, DetteRepoListInt detteRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(DetteRepoListInt) });
                        return constructor?.Invoke(new object[] { detteRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }

        public object GetInstancePaiement(string repoType, string repoType2, PaiementRepoListInt paiementRepo)
        {
            try
            {
                string className = Database.Database.GetActiveDatabase(repoType, repoType2);
                if (className != null)
                {
                    Type clazz = Type.GetType(className);
                    if (clazz != null)
                    {
                        var constructor = clazz.GetConstructor(new Type[] { typeof(PaiementRepoListInt) });
                        return constructor?.Invoke(new object[] { paiementRepo });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            return null;
        }
    }
}

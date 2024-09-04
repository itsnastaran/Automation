using MyProjectt.DataLayer.Repository;
using MyProjectt.DataLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Context
{
    public class UnitOfWord : IDisposable
    {
        projectmainEntities2 db = new projectmainEntities2();
        private GenericRepository<User> _userG;
        public GenericRepository<User> UserGRepository
        {
            get
            {

                if (_userG == null)
                {
                    _userG = new GenericRepository<User>(db);
                }
                return _userG;
            }
        }

        private IUserRepository _user;
        public IUserRepository UserRepository
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(db);
                }
                return _user;
            }
        }

        private GenericRepository<Remember> _rememberG;
        public GenericRepository<Remember> RememberGRepository
        {
            get
            {
                if (_rememberG == null)
                {
                    _rememberG = new GenericRepository<Remember>(db);
                }
                return _rememberG;
            }
        }

        private IRememberRepository _remember;
        public IRememberRepository RememberRepository
        {
            get
            {
                if (_remember == null)
                {
                    _remember = new RememberRepository(db);
                }
                return _remember;
            }
        }

        private GenericRepository<UserType> _userGType;
        public GenericRepository<UserType> UserGtype
        {
            get
            {
                if (_userGType == null)
                {
                    _userGType = new GenericRepository<UserType>(db);
                }
                return _userGType;
            }
        }

        private UserTypeRepository _userType;
        public UserTypeRepository Usertype
        {
            get
            {
                if (_userType == null)
                {
                    _userType = new UserTypeRepository(db);
                }
                return _userType;
            }
        }

        private GenericRepository<UserLog> _userGlog;
        public GenericRepository<UserLog> UserLogGRepository
        {
            get
            {
                if (_userGlog == null)
                {
                    _userGlog = new GenericRepository<UserLog>(db);
                }
                return _userGlog;
            }
        }
        private IULogRepository _userlog;
        public IULogRepository UserLog
        {
            get
            {
                if (_userlog == null)
                {
                    _userlog = new UserLogRepository(db);
                }
                return _userlog;
            }
        }

        private GenericRepository<Job> _jobG;
        public GenericRepository<Job> JobGRepository
        {
            get
            {
                if (_jobG == null)
                {
                    _jobG = new GenericRepository<Job>(db);
                }
                return _jobG;
            }
        }

        private IJobRepository _job;
        public IJobRepository JobRepository
        {
            get
            {
                if (_job == null)
                {
                    _job = new JobRepository(db);
                }
                return _job;
            }
        }
        private GenericRepository<Vw_jobss> _jobG2;
        public GenericRepository<Vw_jobss> JobGRepository2
        {
            get
            {
                if (_jobG == null)
                {
                    _jobG = new GenericRepository<Job>(db);
                }
                return _jobG2;
            }
        }

        private IJobRepository _job2;
        public IJobRepository JobRepository2
        {
            get
            {
                if (_job == null)
                {
                    _job = new JobRepository(db);
                }
                return _job;
            }
        }

        private GenericRepository<UserSetJob> _userjobg;
        public GenericRepository<UserSetJob> USetJobGRepository
        {
            get
            {
                if (_userjobg == null)
                {
                    _userjobg = new GenericRepository<UserSetJob>(db);
                }
                return _userjobg;
            }
        }

        private IUSetJobRepository _userjob;
        public IUSetJobRepository USetJobRepository
        {
            get
            {
                if (_userjob == null)
                {
                    _userjob = new USetJobRepository(db);
                }
                return _userjob;
            }
        }

        private GenericRepository<Letter> _LeterG;
        public GenericRepository<Letter> LeterGRepository
        {
            get
            {
                if (_LeterG == null)
                {
                    _LeterG = new GenericRepository<Letter>(db);
                }
                return _LeterG;
            }
        }

        private ILetterRepository _Letter;
        public ILetterRepository LetterRepository
        {
            get
            {
                if (_Letter == null)
                {
                    _Letter = new LetterRepository(db);
                }
                return _Letter;
            }
        }

        private GenericRepository<AttachFile> _atachfileG;
        public GenericRepository<AttachFile> AtachFileG
        {
            get
            {
                if (_atachfileG == null)
                {
                    _atachfileG = new GenericRepository<AttachFile>(db);
                }
                return _atachfileG;
            }
        }

        private IAttachFileRepository _atachfile;
        public IAttachFileRepository AtachFileRepository
        {
           
            get
            {
                if (_atachfile == null)
                {
                    _atachfile = new AttachFileRepository(db);
                }
                return _atachfile;
            }
        }
        private GenericRepository<SendLetter> _sendlatterg;
        public GenericRepository<SendLetter> SendLatterG
        {
            get
            {
                if (_sendlatterg == null)
                {
                    _sendlatterg = new GenericRepository<SendLetter>(db);
                }
                return _sendlatterg;
            }
        }
        private ISendLetterRepository _sendlatter;
        public ISendLetterRepository SendLatter
        {
            get
            {
                if (_sendlatter == null)
                {
                    _sendlatter = new SendLetterRepository(db);
                }
                return _sendlatter;
            }

        }
        private GenericRepository<Note> _not;
        public GenericRepository<Note> NotRepositoryG
        {
            get
            {
                if (_not == null)
                {
                    _not = new GenericRepository<Note>(db);
                }
                return _not;
            }
        }
        private INotesRepository _notrepository;
        public INotesRepository NotRepository
        {
            get
            {
                if (_notrepository == null)
                {
                    _notrepository = new NotesRepository(db);
                }
                return _notrepository;
            }
        }

        private GenericRepository<SendNote> _sendnotg;
        public GenericRepository<SendNote> SendNotRepositoryG
        {
            get
            {
                if (_sendnotg == null)
                {
                    _sendnotg = new GenericRepository<SendNote>(db);
                }
                return _sendnotg;
            }
        }
        private ISendNoteRepository _sendnot;
        public ISendNoteRepository SendNotRepository
        {
            get
            {
                if (_sendnot == null)
                {
                    _sendnot = new SendNoteRepository(db);
                }
                return _sendnot;
            }
        }
        private GenericRepository<News> _newsG;
        public GenericRepository<News> NewsRepository
        {
            get
            {
                if (_newsG == null)
                {
                    _newsG = new GenericRepository<News>(db);
                }
                return _newsG;
            }
        }

        private INewsRepository _news;
        public INewsRepository NewRepository
        {
            get
            {
                if (_news == null)
                {
                    _news = new NewsRepository(db);
                }

                return _news;
            }
        }
        private GenericRepository<ReferenceLetter> _refrancletter;
        public GenericRepository<ReferenceLetter> RefrenceLetterRepositoryG
        {
            get
            {
                if (_refrancletter == null)
                {
                    _refrancletter = new GenericRepository<ReferenceLetter>(db);
                }
                return _refrancletter;
            }

        }
        private IReferenceLetterRepository _refrencerrepository;
        public IReferenceLetterRepository RefrenceLetterRepository
        {
            get
            {
                if (_refrencerrepository == null)
                {
                    _refrencerrepository = new ReferenceLetterRepository(db);
                }
                return _refrencerrepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                       
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            

        }
    }
}
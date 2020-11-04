using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<Summary>
/// Entity Layer
///</Summary>
namespace SMA.Entity
{
     public class PostDetails
    {
        #region Variables
        int postId;
        int userId;
        string caption, text, imageUrl;
        DateTime datePublished;
        int shareCount, likeCount;
        bool isReported;
        #endregion

        #region Properties
        public int PostId { get => postId;  }
        public int UserId { get => userId; }
        public string Caption { get => caption; set => caption = value; }
        public string Text { get => text; set => text = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public DateTime DatePublished { get => datePublished; set => datePublished = value; }
        public int ShareCount { get => shareCount; set => shareCount = value; }
        public int LikeCount { get => likeCount; set => likeCount = value; }
        public bool IsReported { get => isReported; set => isReported = value; }
        #endregion

        #region Constructors
        public PostDetails()
        {
        }
        #endregion
    }
    
    
    public class UserDetails
    {
        #region Variables
        int userId;
        string userName, userEmail, userPassword;
        string firstName, lastName;
        char gender;
        DateTime dateOfBirth, dateRegistered;
        bool accountStatus;
        #endregion

        #region Properties
        public int UserId{ get => userId;  }
        public string UserName { get => userName;set =>userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime DateRegistered { get => dateRegistered; set => dateRegistered = value; }
        public bool AccountStatus { get => accountStatus; set => accountStatus = value; }
        #endregion

        #region Constructors
        public UserDetails() 
        { 
        }
        #endregion
    }
    
    
    public class FollowerDetails 
    {
        
        #region Variables
        int followId,userId,friendId;
        DateTime dateFollowed;
        #endregion

        #region Properties
        public int FollowId { get => followId;  }
        public int UserId { get => userId; }
        public int FriendId { get => friendId;  }
        #endregion

        #region Constructors
        public FollowerDetails()
        { 
        }
        #endregion
    }

    
    public class AdminDetails 
    {
        
        #region Variables
        int adminId;
        string adminName;
        string adminPassword;
        #endregion

        #region Properties
        public int AdminId { get => adminId; set => adminId = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }
        #endregion

        #region Constructors
        public AdminDetails()
        {
        }
        #endregion
    }
    
    
    public class LogDetails {
        #region Variables
        int logId;
        string errorMessage;
        DateTime errorTime;
        #endregion

        #region Properties
        public int LogId { get => logId; set => logId = value; }
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
        public DateTime ErrorTime { get => errorTime; set => errorTime = value; }
        #endregion

        #region Constructors
        public LogDetails()
        {
        }
        #endregion
    }

}

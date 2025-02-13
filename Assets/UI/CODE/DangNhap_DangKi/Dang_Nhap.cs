using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Extensions;
using UnityEngine;
using UnityEngine.UI;

public class Dang_Nhap : MonoBehaviour, Form_InterFace

{
    [Header("Form")]
    public InputField Gmail;
    public InputField Mat_Khau;



    [Header("Buuton")]
    public Button Dang_Nhap_Button;



    [Header("OBJ")]
    public GameObject OutNhom;




    [Header("FireBase")]
    private FirebaseAuth firebaseAuth;


    void Start()
    {
        firebaseAuth = FirebaseAuth.DefaultInstance;    
        Dang_Nhap_Button.onClick.AddListener(Gui_DuLieu_Sever);
    }




    /// <summary>
    /// Thừa Kế
    /// </summary>
    /// <returns></returns>
    public bool Ckeck_DieuKien()
    {
        return false;
    }

   public void Gui_DuLieu_Sever() // Hàm gửi dữ liệu đăng nhập lên server Firebase
    {
        string Gamil_ = Gmail.text; // Lấy giá trị email từ ô nhập liệu (Gmail là một InputField)
        string Mk = Mat_Khau.text; // Lấy giá trị mật khẩu từ ô nhập liệu (Mat_Khau là một InputField)

        // Gọi Firebase Authentication để đăng nhập bằng email và mật khẩu
        firebaseAuth.SignInWithEmailAndPasswordAsync(Gamil_, Mk).ContinueWithOnMainThread(task => {
            if (task.IsCanceled) { // Kiểm tra nếu task bị hủy
                Debug.LogError("Đăng nhập bị hủy"); // In ra lỗi nếu đăng nhập bị hủy
                return;
            }
            if (task.IsFaulted) { // Kiểm tra nếu có lỗi xảy ra trong quá trình đăng nhập
                Debug.LogError("Đăng nhập thất bại"); // In ra lỗi nếu đăng nhập thất bại
                return;
            }
            if (task.IsCompleted) { // Kiểm tra nếu task hoàn thành
                Debug.Log("Đăng nhập thành công"); // In thông báo nếu đăng nhập thành công
                FirebaseUser user = task.Result.User; // Lấy thông tin của user đã đăng nhập thành công
                OutNhom.SetActive(false);
            }
        });
    }

    public void Nhan_DuLieu_Sever()
    {
       
    }

    
}

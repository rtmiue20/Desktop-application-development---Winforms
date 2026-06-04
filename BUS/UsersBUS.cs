using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS;

public class UsersBUS
{
    private readonly UsersDAL _dal = new();

    // ── Auth ────────────────────────────────────────────────────────────────

    public (bool success, string error) Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return (false, "Vui lòng nhập đầy đủ tài khoản và mật khẩu.");

        var user = _dal.GetByUsername(username);
        if (user == null)
            return (false, "Tài khoản không tồn tại hoặc đã bị vô hiệu hóa.");
        if (user.Password != password)
            return (false, "Mật khẩu không đúng.");

        CurrentUser.UserID   = user.UserID;
        CurrentUser.Username = user.Username;
        CurrentUser.FullName = user.FullName;
        CurrentUser.RoleID   = user.RoleID;

        return (true, null);
    }

    public void Logout() => CurrentUser.Clear();

    // ── CRUD ────────────────────────────────────────────────────────────────

    public List<UsersDTO> GetAll() => _dal.GetAll();

    public UsersDTO? GetByID(int id) => _dal.GetByID(id);

    public (bool success, string error) Insert(UsersDTO user)
    {
        if (string.IsNullOrWhiteSpace(user.Username))
            return (false, "Tên đăng nhập không được để trống.");
        if (string.IsNullOrWhiteSpace(user.Password))
            return (false, "Mật khẩu không được để trống.");
        if (_dal.GetByUsername(user.Username) != null)
            return (false, "Tên đăng nhập đã tồn tại.");

        int id = _dal.Insert(user);
        return id > 0 ? (true, null) : (false, "Thêm nhân viên thất bại.");
    }

    public (bool success, string error) Update(UsersDTO user)
    {
        if (string.IsNullOrWhiteSpace(user.FullName))
            return (false, "Họ tên không được để trống.");

        return _dal.Update(user) ? (true, null) : (false, "Cập nhật thất bại.");
    }

    public (bool success, string error) ChangePassword(int userID, string oldPassword, string newPassword)
    {
        var user = _dal.GetByID(userID);
        if (user == null)
            return (false, "Không tìm thấy tài khoản.");
        if (user.Password != oldPassword)
            return (false, "Mật khẩu cũ không đúng.");
        if (string.IsNullOrWhiteSpace(newPassword))
            return (false, "Mật khẩu mới không được để trống.");

        return _dal.ChangePassword(userID, newPassword)
            ? (true, null)
            : (false, "Đổi mật khẩu thất bại.");
    }

    public (bool success, string error) Deactivate(int userID)
    {
        if (userID == CurrentUser.UserID)
            return (false, "Không thể vô hiệu hóa tài khoản đang đăng nhập.");

        return _dal.Deactivate(userID) ? (true, null) : (false, "Thao tác thất bại.");
    }
}
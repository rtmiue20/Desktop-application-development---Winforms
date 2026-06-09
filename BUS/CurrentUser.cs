namespace BUS
{
    /// <summary>
    /// Lưu thông tin user đang đăng nhập, dùng chung toàn app.
    /// Gán sau khi login thành công, xóa khi logout.
    /// </summary>
    public static class CurrentUser
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static int RoleID { get; set; }
        public static int ShiftID { get; set; }

        public static bool IsManager => RoleID == 1;
        public static bool IsCashier => RoleID == 2;
        public static bool IsWarehouse => RoleID == 3;
        public static bool IsTechnician => RoleID == 4;

        public static bool IsActive { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            FullName = null;
            RoleID = 0;
            ShiftID = 0;
        }
    }
}
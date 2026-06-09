using System;
using System.IO;
using System.Text.Json;

namespace DAL
{
    /// <summary>
    /// Quản lý cấu hình ứng dụng - đọc/ghi file appsettings.json
    /// </summary>
    public static class ConfigManager
    {
        private static readonly string ConfigFilePath = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

        private static DatabaseConfig _currentConfig;

        public class DatabaseConfig
        {
            public string Server { get; set; }
            public string Port { get; set; }
            public string Database { get; set; }
            public string UserId { get; set; }
            public string Password { get; set; }
            public string Charset { get; set; } = "utf8mb4";
        }

        /// <summary>
        /// Đọc cấu hình từ file JSON
        /// </summary>
        public static DatabaseConfig LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        return CreateDefaultConfig();
                    }

                    _currentConfig = JsonSerializer.Deserialize<DatabaseConfig>(json);
                    
                    if (_currentConfig == null)
                    {
                        return CreateDefaultConfig();
                    }

                    return _currentConfig;
                }
                else
                {
                    return CreateDefaultConfig();
                }
            }
            catch (JsonException jsonEx)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Lỗi JSON: {jsonEx.Message}");
                return CreateDefaultConfig();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Lỗi đọc file cấu hình: {ex.Message}");
                return CreateDefaultConfig();
            }
        }

        /// <summary>
        /// Tạo cấu hình mặc định
        /// </summary>
        private static DatabaseConfig CreateDefaultConfig()
        {
            _currentConfig = new DatabaseConfig
            {
                Server = "MinhTrieu-PRE",
                Port = "3306",
                Database = "techstore",
                UserId = "root",
                Password = "",
                Charset = "utf8mb4"
            };
            
            try
            {
                SaveConfig(_currentConfig);
            }
            catch
            {
                // Nếu không thể lưu, vẫn trả về cấu hình mặc định
            }

            return _currentConfig;
        }

        /// <summary>
        /// Lưu cấu hình vào file JSON
        /// </summary>
        public static void SaveConfig(DatabaseConfig config)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(config, options);
                File.WriteAllText(ConfigFilePath, json);
                _currentConfig = config;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Lỗi lưu file cấu hình: {ex.Message}");
                throw new Exception($"Lỗi lưu file cấu hình: {ex.Message}");
            }
        }

        /// <summary>
        /// Tạo connection string từ cấu hình (MariaDB)
        /// </summary>
        public static string GetConnectionString(DatabaseConfig config)
        {
            return $"Server={config.Server};Port={config.Port};Database={config.Database};" +
                   $"Uid={config.UserId};Pwd={config.Password};Charset={config.Charset};";
        }

        /// <summary>
        /// Lấy cấu hình hiện tại
        /// </summary>
        public static DatabaseConfig GetCurrentConfig()
        {
            return _currentConfig ?? LoadConfig();
        }
    }
}
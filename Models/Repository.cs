namespace PartyInvites.Models
{
    public static class Repository
    {
        // 私有静态字段，用于存储所有的 GuestResponse 对象
        private static List<GuestResponse> responses = new();

        // 公共静态属性，返回 responses 列表的只读视图
        public static IEnumerable<GuestResponse> Responses => responses;

        // 公共静态方法，用于添加新的 GuestResponse 对象到 responses 列表中
        public static void AddResponse(GuestResponse response)
        {
            // 打印 response 对象到控制台（调试用途）
            Console.WriteLine(response);
            // 将 response 对象添加到 responses 列表中
            responses.Add(response);
        }
    }
}

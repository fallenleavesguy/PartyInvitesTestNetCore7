namespace PartyInvites.Models
{
    public static class Repository
    {
        // ˽�о�̬�ֶΣ����ڴ洢���е� GuestResponse ����
        private static List<GuestResponse> responses = new();

        // ������̬���ԣ����� responses �б��ֻ����ͼ
        public static IEnumerable<GuestResponse> Responses => responses;

        // ������̬��������������µ� GuestResponse ���� responses �б���
        public static void AddResponse(GuestResponse response)
        {
            // ��ӡ response ���󵽿���̨��������;��
            Console.WriteLine(response);
            // �� response ������ӵ� responses �б���
            responses.Add(response);
        }
    }
}

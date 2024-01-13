


using Azure.AI.OpenAI;

//chat gpt api key
OpenAIClient client = new OpenAIClient("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");

Console.WriteLine("Chat GPT 3.5");

while (true)
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("You: ");
    Console.ResetColor();
    string input = Console.ReadLine() ?? string.Empty;

    if (input.ToLower() == "exit")
        break;

    var OpenAIResponse = await client.GetChatCompletionsAsync("gpt-3.5-turbo", new ChatCompletionsOptions
    {
        Messages =
    {
        new ChatMessage(ChatRole.System,input)
    }
    });

    foreach (var Choice in OpenAIResponse.Value.Choices)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Chatbot: ");
        Console.ResetColor();
        Console.WriteLine(Choice.Message.Content);
    }

    
}
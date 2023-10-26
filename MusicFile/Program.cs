using System.Diagnostics;

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://mp3party.net/music/10817608.mp3");
byte[] data = response.Content.ReadAsByteArrayAsync().Result;
File.WriteAllBytes("C:\\Users\\Антисептик\\Desktop\\manera.mp3", data);

Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Антисептик\\Desktop\\manera.mp3", UseShellExecute = true });

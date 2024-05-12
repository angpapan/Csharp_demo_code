public async Task<string> DownloadWebPageAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        //Asynchronously send a GET request to the specified URL
        HttpResponseMessage resp = await client.GetAsync(url);
        
        //Asynchronously read the content of the response
        string cont = await resp.Content.ReadAsStringAsync();
        
        return cont; // Return the downloaded content
    }
}
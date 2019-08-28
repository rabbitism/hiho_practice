from bs4 import BeautifulSoup
import time
import requests


def load_content():
    htmlf = open("./README_Update/source.html", 'r', encoding="utf-8")
    htmlcontent = htmlf.read()
    headers = {
        "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
        "Accept-Encoding": "gzip, deflate",
        "Connection": "keep-alive",
        "Cookie": "Hm_lvt_9334676254a219943ea90c19530c3bec=1564840306,1565836773,1566894563; PHPSESSID=6pm4fpcvgr7tpa2i7bffjvhd67; Hm_lpvt_9334676254a219943ea90c19530c3bec=1566957735",
        "Host": "hihocoder.com",
        "Referer": "http://hihocoder.com/hiho",
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3879.0 Safari/537.36 Edg/78.0.249.1"
    }
    r = requests.get("http://hihocoder.com/problemset", headers = headers)
    htmlcontent = r.text
    return htmlcontent


def parse(content: str):
    soup = BeautifulSoup(content, 'lxml')
    content = soup.find_all('tr')
    result = {}
    for line in content:
        id = line.find(attrs={'class': 'id'}).get_text()
        if(id == 'ID'):
            continue
        else:
            id = line.find(attrs={'class': 'id'}).find('a').get_text()
            status = line.find(attrs={'class': 'id'}).find(
                'span').attrs['title']
            name = line.find(attrs={'class': 'name'}).get_text()
            tags = []
            for badgeline in line.find_all(attrs={'class': 'badge'}):
                tag = badgeline.get_text().strip()
                if(len(tag) > 0):
                    tags.append(badgeline.get_text())
            difficulty = line.find(attrs={'class': 'def'}).get_text()
            solved = line.find(attrs={'class': 'ratio'}).get_text()
            result[id] = {'status': status, 'name': name,
                          'tags': tags, 'difficulty': difficulty, 'solved': solved}
    return result


def generate(result: dict):
    with open("./README.MD", 'w', encoding='utf-8') as f:
        f.writelines(r"# HihoCoder Practice Archive"+"\n\n")
        f.writelines(r"This is an archive repository for hihocoder questions and my solutions."+"\n\n")
        f.writelines(r"## Environment"+"\n\n")
        f.writelines(r".Net Core 2.1.403"+"\n\n")
        f.writelines(r"## How to use"+"\n\n")
        f.writelines(r"Every problem is constructed under an individual project. For projects with standard input, sample input has been already stored in corresponding file with name `input`. You can use it with following command:"+"\n\n")
        f.writelines(r"```shell"+"\n"+r"cat input | dotnet run"+"\n```"+"\n\n")
        f.writelines(r"# Problem List"+"\n\n")
        f.writelines(r"Updated on " +
                     time.strftime("%Y-%m-%d", time.localtime())+"\n")
        statusSum = {}
        for id in result.keys():
            status = result[id]['status']
            if(status in statusSum.keys()):
                statusSum[status] += 1
            else:
                statusSum[status] = 1
        # print(statusSum)
        for key in statusSum.keys():
            title = 'Not tried' if key == '' else key.capitalize()
            f.writelines("\n"+r"## " + title + "("+str(statusSum[key])+")\n\n")
            f.writelines(r"|ID|Name|Tags|Difficulty|Solved|Solution|" +
                         "\n"+r"|:---:|:---|:---|:---:|:---|:---:|"+"\n")
            for id in result.keys():
                attributes = result[id]
                if(attributes['status'] == key):
                    f.write(
                        "|["+id+"](http://hihocoder.com/problemset/problem/"+id+")")
                    f.write("|"+attributes['name'])
                    f.write("|")
                    if(len(attributes['tags']) > 0):
                        for tag in attributes['tags']:
                            f.write("`"+tag+"` ")
                    f.write("|"+attributes['difficulty'])
                    f.write("|"+attributes['solved'])
                    path = '' if key == '' else "["+id+"](/Solutions/"+id+")"
                    f.write("|"+path)
                    f.write("|\n")


if __name__ == "__main__":
    generate(parse(load_content()))

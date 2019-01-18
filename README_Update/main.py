from bs4 import BeautifulSoup
import time

def load_content():
    htmlf = open("source.html", 'r', encoding="utf-8")
    htmlcontent = htmlf.read()
    return htmlcontent

def parse(content:str):
    soup = BeautifulSoup(content, 'lxml')
    content = soup.find_all('tr')
    result = {}
    for line in content:
        id = line.find(attrs={'class':'id'}).get_text()
        if(id=='ID'):
            continue
        else:
            id = line.find(attrs={'class':'id'}).find('a').get_text()
            status = line.find(attrs={'class':'id'}).find('span').attrs['title']
            name = line.find(attrs={'class':'name'}).get_text()
            tags = []
            for badgeline in line.find_all(attrs={'class':'badge'}):
                tag = badgeline.get_text().strip()
                if(len(tag)>0):
                    tags.append(badgeline.get_text())
            difficulty = line.find(attrs={'class':'def'}).get_text()
            solved = line.find(attrs={'class':'ratio'}).get_text()
            result[id] = {'status':status, 'name':name, 'tags':tags, 'difficulty':difficulty, 'solved':solved}
    return result

def generate(result:dict):
    with open("README.MD", 'w', encoding='utf-8') as f:
        f.writelines(r"# HihoCoder Practice Archive"+"\n\n")
        f.writelines(r"This is an archive repository for hihocoder questions and my solutions."+"\n")
        f.writelines(r"## Environment"+"\n")
        f.writelines(r".Net Core 2.1.403"+"\n\n")
        f.writelines(r"## How to use"+"\n")
        f.writelines(r"Every problem is constructed under an individual project. For projects with standard input, sample input has been already stored in corresponding file with name `input`. You can use it with following command:"+"\n\n")
        f.writelines(r"```csharp"+"\n"+r"cat input | dotnet run"+"\n```"+"\n")
        f.writelines(r"# Problem List"+"\n")
        f.writelines(r"Updated on "+time.strftime("%Y-%m-%d", time.localtime())+"\n")
        statusSum = {}
        for id in result.keys():
            status = result[id]['status']
            if(status in statusSum.keys()):
                statusSum[status]+=1
            else:
                statusSum[status]=1
        #print(statusSum)
        for key in statusSum.keys():
            title = 'Not tried' if key=='' else key.capitalize()
            f.writelines("\n"+r"## "+ title +"("+str(statusSum[key])+")\n\n")
            f.writelines(r"|ID|Name|Tags|Difficulty|Solved|Solution|"+"\n"+r"|:---:|:---|:---|:---:|:---|:---:|"+"\n")
            for id in result.keys():
                attributes = result[id]
                if(attributes['status']==key):
                    f.write("|["+id+"](http://hihocoder.com/problemset/problem/"+id+")")
                    f.write("|"+attributes['name'])
                    f.write("|")
                    if(len(attributes['tags'])>0):
                        for tag in attributes['tags']:
                            f.write("`"+tag+"` ")
                    f.write("|"+attributes['difficulty'])
                    f.write("|"+attributes['solved'])
                    path = '' if key=='' else "["+id+"](/"+id+")"
                    f.write("|"+path)
                    f.write("|\n")

        
        

if __name__ == "__main__":
    generate(parse(load_content()))
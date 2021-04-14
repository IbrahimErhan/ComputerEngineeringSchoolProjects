import re

class NgramAnalysis:
    
    """
        This function splits text to each word.
        Text is the corpus taken from text files.
    """
    def GenerateWordList(self,text):
        text = re.sub(r'[\t\n\r]', '', text)
        rawWords = re.split(r'[\*\:\;\\()\'\" ?.,+-]', text)
        words = []
        for word in rawWords:
            if(len(word) != 0):
                words.append(word)
        return words
        
    """ 
        N-gram analysis functions for each n equals 1, 2, 3.
    """
    def GenerateUnigram(self,words):
        searchedWords = []
        UnigramDic = {}
        count = 0
        for i in range(0,len(words)):
            try:
                searchedWords.index(words[i])
            except:
                searchedWords.insert(len(searchedWords),words[i])
                for j in range(0,len(words)):
                    if(words[i] == words[j]):
                        count+=1
                UnigramDic.update({words[i] : count})
                count = 0
        return UnigramDic

    def GenerateBigram(self,words):
        searchedWords = []
        BigramDic = {}
        count = 0
        for i in range(0,len(words) - 1):
            try:
                searchedWords.index(words[i] + words[i + 1])
            except:
                searchedWords.insert(len(searchedWords),words[i] + words[i + 1])
                for j in range(0,len(words) - 1):
                    if((words[i] == words[j]) & (words[i + 1] == words[j + 1])):
                        count+=1
                BigramDic.update({words[i] + ' ' + words[i + 1] : count})
                count = 0
        return BigramDic

    def GenerateTrigram(self,words):
        searchedWords = []
        TrigramDic = {}
        count = 0
        for i in range(0,len(words) - 2):
            try:
                searchedWords.index(words[i] + words[i + 1] + words[i + 2])
            except:
                searchedWords.insert(len(searchedWords),words[i] + words[i + 1] + words[i + 2])
                for j in range(0,len(words) - 2):
                    if((words[i] == words[j]) & (words[i + 1] == words[j + 1]) & (words[i + 2] == words[j + 2])):
                        count+=1
                TrigramDic.update({words[i] + ' ' + words[i + 1] + ' ' + words[i + 2]: count})
                count = 0
        return TrigramDic

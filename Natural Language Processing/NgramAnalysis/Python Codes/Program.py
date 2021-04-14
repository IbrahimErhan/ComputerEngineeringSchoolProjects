from NgramAnalysis import NgramAnalysis
import datetime

ngramAnalysis = NgramAnalysis()

# Reading corpus text files.
print('====== Python N-gram Implementation ======')
try:
    print('Reading from texts...')
    with open('BİLİM İŞ BAŞINDA.txt', 'r') as file1:
        text = file1.read()
    with open('BOZKIRDA.txt', 'r') as file2:
        text += (' ' +  file2.read())
    with open('DEĞİŞİM.txt', 'r') as file3:
        text += (' ' +  file3.read())
    with open('DENEMELER.txt', 'r') as file4:
        text += (' ' +  file4.read())
    with open('UNUTULMUŞ DİYARLAR.txt', 'r') as file5:
        text += (' ' +  file5.read())
    print('Reading completed.')
except:
    print('Reading failed... Files not found.')

text = text.lower()
words = ngramAnalysis.GenerateWordList(text)

# N-gram analysis with execution time calculation.
print('N-gram Analysis started... This will take a moment...')
startTime = datetime.datetime.now()
UniGramStartTime = datetime.datetime.now()
UniGramDic = ngramAnalysis.GenerateUnigram(words)
UniGramStopTime = datetime.datetime.now()
UniGramElapsedTime = UniGramStopTime - UniGramStartTime
print('Unigram Analysis completed... Elapsed Time :', UniGramElapsedTime, ' Bigram Analysis started...')

BiGramStartTime = datetime.datetime.now()
BiGramDic = ngramAnalysis.GenerateBigram(words)
BigramStopTime = datetime.datetime.now()
BiGramElapsedTime = BigramStopTime - BiGramStartTime
print('Bigram Analysis completed... Elapsed Time : ', BiGramElapsedTime, ' Trigram Analysis started...')

TriGramstartTime = datetime.datetime.now()
TriGramDic = ngramAnalysis.GenerateTrigram(words)
TrigramStopTime = datetime.datetime.now()
TriGramElapsedTime = TrigramStopTime - TriGramstartTime
print('Trigram Analysis completed. Elapsed Time : ', TriGramElapsedTime)

stopTime = datetime.datetime.now()
elapsedTime = stopTime - startTime
print('Total Elapsed time : ', elapsedTime)

sortedUniGramDic = sorted(UniGramDic.items(), key=lambda x: x[1], reverse = True)
sortedBiGramDic = sorted(BiGramDic.items(), key=lambda x: x[1], reverse = True)
sortedTriGramDic = sorted(TriGramDic.items(), key=lambda x: x[1], reverse = True)

# Writing analysis results to text. Ex. ('N-gram', 'count')
print('Writing results to text files...')
with open('Python-Results-Unigram.txt', 'w') as f:
    for value in sortedUniGramDic:
        print(value, file = f)

with open('Python-Results-bigram.txt', 'w') as f:
    for value in sortedBiGramDic:
        print(value, file = f)

with open('Python-Results-Trigram.txt', 'w') as f:
    for value in sortedTriGramDic:
        print(value, file = f)
print('Writing completed.')
参考：https://www.zhihu.com/question/65224766
对于某些flv文件，转换成mp4的时候会报错，这时候可以用以下的代码来尝试：
ffmpeg -i filename.flv -c:v libx264 -crf 19 -strict experimental filename.mp4
将这里的filrename改为你的文件名即可

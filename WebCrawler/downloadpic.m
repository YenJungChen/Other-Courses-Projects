function pic=downloadpicture(URL,M)
    warning off;
    [sourcefile, status]=urlread(sprintf(URL));   %call urlread to load the url, if existed, return 1
                                                  %if not, return 0 and print error
                                                  %sourcefile = the code of the url, to crawl picture's url
    if ~status
        error('error\n')
    end
    %compare the url of pictures, in order to skip ads. the uni form: (http://pic.pimg.tw/plum0925/)
    %[^"]* = arbitrary
    expr1='http://pic.pimg.tw/plum0925/[^"]*.jpg';
    %use regexp to compare the same exprl from code
    %datafile = the things we found, cell type
    [datefile, date_tokens]=regexp(sourcefile,expr1,'match','tokens'); 
    len_datafile=length(datefile);
    %create folder path. num2str = transform the argument to string. -1 = to crawl from layer 2
    PATH=['\picture\' num2str(M-1)];
    %pwd = path of .m (current)
    pathname=[pwd PATH];
    if ~exist(pathname,'dir')   %check if the path existed, if not, create
        mkdir(pathname);
    end
    for i=1:len_datafile
        filename=sprintf('.jpg');     
        num=num2str(i);
        File=[num filename];    %1.jpg
        fullfilepath=[pathname '\' File];   %D:\Tiling_Grid_CBIR\picture\1\1.jpg
        urlwrite(datefile{i},fullfilepath);     %store the images
    end
    fprintf('¥»­¶§¹¦¨¡I\n')
    DT(PATH,M-1);	%call DT to merge images
end
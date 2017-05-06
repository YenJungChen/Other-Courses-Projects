function [NoorImage resized]=YDynamicTiling(URows,UCols,NImgRows,NImgCols,PATH)

UserRows=URows;
UserCols=UCols;

NewImageRows=NImgRows;
NewImageCols=NImgCols;

NewRsizeRows=floor(NewImageRows/UserRows);
NewRsizeCols=floor(NewImageCols/UserCols);
%fullfile read all the .jpg from the folder
jpg_files = dir(fullfile([pwd PATH ],'*.jpg'));
if (size(jpg_files,1)< 1)
    disp('No files found.......  Quiting.....');
    return;
end

Color_Image=1;
fileJPG_path=[pwd PATH '\' jpg_files(1).name];
test_i=imread(fileJPG_path);
if (size(test_i,3)>2)
else
    Color_Image=0;
end
n=size(jpg_files,1);
f = ceil(n.*rand(n,1));
noorRandom=f;
%size(jpg_files) = the amount of total img¡Aread all, uniform the dimensions
for k=1:size(jpg_files,1)
     fileJPG_path=[pwd PATH '\' jpg_files(k).name];
     i=imread(fileJPG_path);
        resized(k).imageData=imresize(i,[NewRsizeRows NewRsizeCols]);
 end

 CValue=NewRsizeCols;
 RVal=NewRsizeRows;
 
 k=0;
 for i=0:UserCols-1
     for j=0:UserRows-1
        k=k+1;
        k=mod(k,n)+1;
           if Color_Image==0
                 NoorImage(((j*RVal)+1):((j*RVal)+ RVal),((i*CValue)+1):((i*CValue)+ CValue)) =resized(noorRandom(k)).imageData; 
           else
                 NoorImage(((j*RVal)+1):((j*RVal)+ RVal), ((i*CValue)+1):((i*CValue)+ CValue),1) =resized(noorRandom(k)).imageData(:,:,1);  
                 NoorImage(((j*RVal)+1):((j*RVal)+ RVal), ((i*CValue)+1):((i*CValue)+ CValue),2) =resized(noorRandom(k)).imageData(:,:,2);  
                 NoorImage(((j*RVal)+1):((j*RVal)+ RVal), ((i*CValue)+1):((i*CValue)+ CValue),3) =resized(noorRandom(k)).imageData(:,:,3);  
           end
     end
 end
end


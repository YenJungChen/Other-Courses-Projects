function DT(path,num)

disp(path);

prompt = {'Enter Number of Images in Rows:','Enter Number of Images in Cols:','Enter Image-Rows','Enter Image-Cols'};
dlg_title = 'Input for Image Tiling';
num_lines = 1;
def = {'4','4','800','800'};
%enter the pixel of images and dimensions of the puzzle
answer = inputdlg(prompt,dlg_title,num_lines,def);
%RyImg = puzzle
[RyImg]=YDynamicTiling(str2num(answer{1}),str2num(answer{2}),str2num(answer{3}),str2num(answer{4}),path);

figure,imshow(RyImg);
%the data of merged images, setting path and filename
filename = sprintf('.jpg');     
num=num2str(num);
File=[num filename];
imwrite(RyImg, File);
end

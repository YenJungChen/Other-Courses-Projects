function mosaic
[full_image] = imread('full.jpg');  %the puzzle's shape
info = imfinfo('full.jpg');
%width and height of the puzzle
size_x_full = info.Width;
size_y_full = info.Height;
figure;
image(full_image);
%the path of the img which we used to make the puzzle
[tile] = imread('E:\照片\大學-高大\吳秦至秦\IMAG013333.jpg');
tile_info = imfinfo('E:\照片\大學-高大\吳秦至秦\IMAG013333.jpg');
size_x_tile = tile_info.Width;
size_y_tile = tile_info.Height;
%image(tile);

num_x_tile = 50;  %dimension 
num_y_tile = 50;

count = 1;
num_cells = num_x_tile * num_y_tile;
size_x_tile = round(size_x_tile / num_x_tile)-1; %narrow down the original img
size_y_tile = round(size_y_tile / num_y_tile)-1;

clear aver;
for j = 0:num_y_tile-1,
   for i = 0:num_x_tile-1,
      temp = tile(j*size_y_tile+1:(j+1)*size_y_tile, i*size_x_tile+1:(i+1)*size_x_tile, :);  %thumbnail   
        tile_small(j+1, i+1, 1) = mean(mean(mean(temp(:, :, :))));
        tile_small(j+1, i+1, 2) = mean(mean(mean(temp(:, :, :))));
        tile_small(j+1, i+1, 3) = mean(mean(mean(temp(:, :, :))));
      axis off;
   end
end
%execute mean and max to make grayscale
rmax = max(max(tile_small(:, :, 1)));
gmax = max(max(tile_small(:, :, 2)));
bmax = max(max(tile_small(:, :, 3)));
tile_small(:, :, 1) = tile_small(:, :, 1)./rmax;
tile_small(:, :, 2) = tile_small(:, :, 2)./gmax;
tile_small(:, :, 3) = tile_small(:, :, 3)./bmax;
imwrite(tile_small,'tile_smile.jpg');
figure; %print the thumbnail
image(tile_small);

clear aver;

% Try changing these numbers
num_x = 40;
num_y = 40;

count = 1;
num_cells = num_x * num_y;
size_x = round(size_x_full / num_x)-1;
size_y = round(size_y_full / num_y)-1;

for j = 0:num_y-1,
   for i = 0:num_x-1,
      temp = full_image(j*size_y+1:(j+1)*size_y, i*size_x+1:(i+1)*size_x, :);
      count = count + 1;
                aver(j+1, i+1, 1) = mean(mean(mean(temp(:, :, :))));
                aver(j+1, i+1, 2) = mean(mean(mean(temp(:, :, :))));
                aver(j+1, i+1, 3) = mean(mean(mean(temp(:, :, :))));
      axis off;
   end
end
%make grayscale and thumbnail puzzle
rmax = max(max(aver(:, :, 1)));
gmax = max(max(aver(:, :, 2)));
bmax = max(max(aver(:, :, 3)));
aver_scaled(:, :, 1) = aver(:, :, 1)./rmax;
aver_scaled(:, :, 2) = aver(:, :, 2)./gmax;
aver_scaled(:, :, 3) = aver(:, :, 3)./bmax;
figure;
image(aver_scaled);
imwrite(aver_scaled,'aver_scaled.jpg');
for j = 0:num_y-1,
   for i = 0:num_x-1,
        composite(j*num_y_tile+1:(j+1)*num_y_tile, i*num_x_tile+1:(i+1)*num_x_tile, :) = tile_small.*aver_scaled(j+1, i+1);     %灰灰的愛心跟灰灰的縮圖疊在一起
   end
end
image(composite);
axis off;
imwrite(composite, 'mazac.jpg');
end
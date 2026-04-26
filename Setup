CREATE DATABASE WebNauAn;
GO
USE WebNauAn;

-- DANH MỤC
CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100)
);

-- MÓN ĂN
CREATE TABLE Recipes (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Description NVARCHAR(500),
    Image NVARCHAR(300),
    RecipeDetail NVARCHAR(MAX),
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

-- USER
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50),
    Password NVARCHAR(50)
);
INSERT INTO Users (Username, Password) VALUES ('admin', '123')

-- DATA CATEGORY
INSERT INTO Categories VALUES 
(N'Món Nước'),
(N'Món Chiên'),
(N'Món Xào'),
(N'Món Kho'),
(N'Món Canh'),
(N'Món Lẩu'),
(N'Ăn vặt');

-- DATA RECIPES
INSERT INTO Recipes (Name, Description, RecipeDetail, Image, CategoryId)
VALUES
(N'Phở bò', N'Ngon truyền thống',
N'Ninh xương bò 6 tiếng...', '/images/phobo.jpg', 1),
(N'Hủ tiếu', N'Món miền Nam',
N'Nấu nước dùng...', '/images/hutieu.jpg', 1);

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Phở bò (nấu với gói gia vị phở) Cho 4 người
 - Phở 1 gói
  - Thịt bò 500 gr
  - Xương heo 100 gr
  - Gia vị nấu phở bò 1 gói
  - Hành tây 1 củ
  - Hành tím 4 củ
  - Gừng 1 củ
  - Đường phèn 2 muỗng canh
  - Rau ăn phở 1 ít
  - Gia vị thông dụng . 1 ít
(hạt nêm/ đường/ bột ngọt/ muối)

Cách chọn mua xương heo tươi ngon
Bạn nên chọn mua xương heo có màu tươi và phần xương có độ to trung bình, vừa phải, kích thước xương to khoảng 2- 3 đốt ngón tay.
Không nên chọn mua xương heo có màu tái, mùi hôi lạ và khi cầm lên thì thấy nhớt.
Xương ống ngon có màu tươi, không tái, không có mùi lạ và không bị lạnh, to khoảng 2 - 3 đốt ngón
Nơi mua gói gia vị phở
Bạn có thể dễ dàng tìm mua các gói gia vị phở ở siêu thị, cửa hàng tạp hóa, các trang thương mại điện tử.
Ngoài ra, bạn cũng có thể tìm mua tại các cửa hàng Bách hóa XANH trên toàn quốc và mua hàng thông qua website bachhoaxanh.com.
Cách chế biến Phở bò (nấu với gói gia vị phở)
1.Sơ chế và chần thịt
Bạn bắc lên bếp 1 nồi nước và cho vào nồi hành tím đã đập dập rồi nấu trên bếp ở nhiệt độ cao.
Khi nước sôi, bạn cho thịt bò và xương heo đã sơ chế vào và chần khoảng 3 phút để loại bỏ mùi hôi. Sau đó, bạn vớt thịt ra và cho ngay vào tô nước lạnh.
2.Sơ chế các nguyên liệu khác
Hành tím mua về bạn lột vỏ 3 củ, sau đó rửa sạch và đập dập, 2 củ còn lại thì rửa sạch và để ráo.
Hành tây cắt bỏ rễ, và rửa sạch. Bạn rửa sạch gừng và để ráo.
Nướng hành tây, 2 củ hành tím và gừng trên bếp khoảng 2 phút đến khi dậy mùi thơm.
Bạn cho phần gia vị nấu phở bò vào chảo và rang trên bếp ở nhiệt độ trung bình nhỏ trong 4 phút đến khi dậy mùi thơm. Cho các gia vị vừa rang vào túi lọc có sẵn và cột chặt miệng túi lại.
3.Nấu nước dùng
Bạn cho vào nồi 1.5 lít nước cùng thịt bò và xương heo đã chần rồi đậy nắp lại, hầm trong 1 tiếng. Trong lúc hầm nước dùng, bạn thường xuyên mở nắp nồi và hớt sạch bọt để nước dùng được trong hơn nhé!
Khi nước sôi, bạn cho hành tây, hành tím, gừng đã nướng thơm và túi gia vị nấu phở đã rang vào nồi.
Tiếp theo, bạn thêm vào nồi 2 muỗng canh đường phèn, 2 muỗng cà phê muối, 1.5 muỗng cà phê bột ngọt, 1.5 muỗng cà phê hạt nêm rồi khuấy đều, nêm nếm lại gia vị cho vừa ăn và nắp lại 3 phút rồi tắt bếp là hoàn thành.
4.Hoàn thành
Bạn vớt thịt bò trong nồi nước dùng ra và cắt thành những lát vừa ăn.
Sau đó, cho bánh phở ra tô, xếp thịt bò lên trên rồi chan nước dùng và thêm ít ớt cắt lát, rau ăn phở như ngò gai, hành lá,...
5.Thành phẩm
Vậy là tô phở bò nấu từ gói gia vị phở chỉ với vài bước cơ bản đã hoàn thành rồi.
Nước dùng thì đậm đà, ngọt thanh từ xương, hành tím, hành tây xen lẫn mùi gừng thơm phức kết hợp với thịt bò mềm, béo ngậy cùng bánh phở mềm, dai. Tất cả tạo nên tô phở bò hấp dẫn, thơm ngon khó lòng mà chối từ.'
WHERE Id = 0;

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU:Cho 6 - 8 người
 - Cá tai tượng 2 con(khoảng 1.2 - 1.5kg/con)
 - Dầu ăn 1 lít(hoặc nhiều hơn)
 - Bún tươi 1 kg
 - Chuối chát 5 quả(chuối xanh)
 - Khế chua 5 quả
 - Rau ăn kèm 1 ít(xà lách/ rau thơm/ lá cách/...)
 - Khóm 1 trái
 - Tỏi/ ớt 1 ít
 - Mắm nêm 200 gr
 - Chanh tươi/ muối/ tắt / cơm mẻ 1 ít
 - Bánh tráng cuốn 1 ít

Cách chọn mua cá tai tượng tươi
Nên chọn cá tai tượng còn bơi khỏe trong bể nước, vì thịt sẽ ngon ngọt, chắc và ít tanh hơn.
Lật mang cá ra xem, nếu mang màu đỏ tươi hoặc hồng sẫm, không có mùi lạ, đó là cá mới bắt hoặc mới giết mổ.
Cá tươi sẽ có thịt săn chắc, có độ đàn hồi tốt, mắt cá hơi lồi và trong suốt còn vảy cá thì sáng bóng, bám chắc vào da.
Cách chế biến Cá tai tượng chiên xù cuốn bánh tráng

1.Sơ chế nguyên liệu
Cá tai tượng mua về thì bạn hãy dùng dao hoặc kéo mổ bụng, bỏ ruột và mang cá. Chú ý không cắt bỏ vây, đuôi hay đánh vảy nhé. Bạn dùng chanh và muối chà xát kỹ toàn thân cá để khử nhớt và mùi tanh.
Tiếp đến, bạn rửa lại cá bằng nước sạch, để thật ráo (hoặc dùng khăn giấy thấm khô cá).
Bạn lặt rau sống và lá cách, sau đó rửa qua 3 - 4 lần nước cho sạch bùn đất rồi vớt ra rổ để ráo nước. Chuối chát tước bỏ lớp vỏ ngoài, thái lát mỏng. Ngâm chuối trong thau nước có pha nước tắc hoặc cơm mẻ để giữ màu trắng, không bị thâm.
Khế chua gọt cạnh, rửa sạch, thái lát mỏng. Khóm rửa sạch, bằm nhuyễn hoặc nạo lấy phần thịt. Tỏi và ớt rửa sạch, bằm nhuyễn (số lượng tùy thuộc vào sở thích ăn cay và số lượng người ăn).
2.Chiên cá tai tượng
Bạn cho vào chảo lượng dầu đủ ngập lưng cá vào chảo, bật bếp đun ở lửa vừa cho đến khi thấy dầu thật nóng, đến mức sôi già. Nhẹ nhàng gắp cá tai tượng đã ráo nước cho vào chảo dầu nóng. Bạn sẽ chiên cá ở lửa vừa để cá chín kỹ phần thịt bên trong.
Trong khi chiên, liên tục múc dầu nóng trong chảo rưới lên mình cá (nhất là phần chưa ngập dầu). Việc này giúp vảy cá xù lên đều, lớp da bên ngoài giòn mà không bị khô.
Khi mặt dưới đã vàng đều thì bạn từ từ lật cá sang mặt còn lại, thao tác nhẹ tay để cá không bị nát. Tiếp tục chiên thêm khoảng 10 phút hoặc đến khi cá vàng giòn cả hai mặt, có mùi thơm nức là đạt.
3.Pha mắm nêm
Bắc chảo lên bếp, bạn cho vào chảo khoảng 1 muỗng canh dầu ăn rồi cho tỏi ớt băm vào phi thơm. Tiếp đến, bạn cho khóm vào xào ở lửa vừa, đảo liên tục đến khi khóm mềm, dậy mùi thơm và hơi kẹo lại (khoảng 3 - 5 phút).
Bạn cho 200gr mắm nêm vào chảo, hạ lửa nhỏ rồi vừa đun, vừa khuấy đều cho đến khi hỗn hợp sôi trở lại. Nếu mắm nêm quá đặc thì bạn có thể cho thêm 1 ít nước lọc nhé. Bạn nêm khoảng 3 - 4 muỗng canh đường (tùy khẩu vị), nêm nếm lại cho vừa miệng.
Sau đó, bạn tắt bếp, để mắm nêm nguội bớt rồi mới vắt 1 ít nước cốt tắc hoặc chanh vào cho hài hòa.
4.Thành phẩm
Khi cá đã chiên vàng giòn hai mặt, gắp ra đĩa có lót sẵn giấy thấm dầu để loại bỏ bớt dầu thừa. Khi ăn, gắp một miếng thịt cá (có thể kèm theo phần vảy giòn rụm nếu thích), đặt lên miếng bánh tráng, thêm bún, rau sống, chuối chát, khế chua rồi cuốn gọn lại, chấm đẫm vào chén mắm nêm thơm nồng, đậm vị.
Hương vị cá tai tượng chiên xù có lớp vảy giòn rụm, phần thịt mềm béo, vẫn còn mọng nước khi kết hợp với bánh tráng cuốn và mắm nêm hài hòa mặn ngọt chắc chắn sẽ khiến bạn xuýt xoa mãi không thôi.
'
WHERE Id = 5; 


UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Thịt ba rọi chiên nước mắm Cho 4 người
 - Thịt ba rọi 600 gr
 - Bột chiên giòn 3 muỗng canh
 - Bột gạo 3 muỗng canh
 - Hành tím 5 củ
 - Gừng 1 nhánh
 - Tỏi 2 tép
 - Ớt 1 trái
 - Nước mắm 2 muỗng canh
 - Dầu ăn 330 ml
 - Gia vị thông dụng 1 ít
(Hạt nêm/ muối/ đường)

Cách chế biến Thịt ba rọi chiên nước mắm
1.Sơ chế thịt
Xoa bóp đều miếng thịt heo với 1 muỗng canh muối khoảng 5 phút. Sau đó rửa lại bằng nước sạch, để ráo nước.
2.Sơ chế các nguyên liệu khác
Gừng gọt vỏ, rửa sạch và cắt lát.
Hành tím lột vỏ, rửa sạch, cắt lát 2 củ, phần còn lại băm nhỏ.
Tỏi lột vỏ, rửa sạch, băm nhỏ.
Ớt rửa sạch, băm nhuyễn.
3.Luộc thịt
Bắc một nồi nước lên bếp, cho vào gừng cắt lát, 2 củ hành tím cắt lát, 1 muỗng cà phê muối sau đó luộc thịt heo trong 5 phút.
Vớt thịt heo ra, dùng dao khứa nhiều đường lên phần da, sau đó để ráo nước. Cách này giúp da khi chiên sẽ giòn và phồng hơn.
4.Ướp thịt
Cho vào tô lớn phần thịt heo đã luộc, 1/2 muỗng canh hạt nêm, 1/2 muỗng cà phê đường, 1/2 muỗng canh nước mắm, 1 muỗng cà phê hỗn hợp hành tím, tỏi và ớt băm nhuyễn và trộn đều.
Ướp thịt trong 20 phút.
5.Nhúng bột thịt
Cho 3 muỗng canh bột chiên giòn, 3 muỗng canh bột gạo vào dĩa lớn rồi trộn đều.
Lấy từng phần thịt cho vào dĩa và áo đều bột.
6.Chiên thịt
Bắc chảo lên bếp, cho 300ml dầu ăn vào và đợi dầu sôi.
Lần lượt cho thịt đã áo bột vào chảo và chiên đến khi thịt chín vàng đều 2 mặt.
7.Làm thịt chiên nước mắm
Bắc chảo mới lên bếp cùng 2 muỗng canh (30ml) dầu ăn, cho phần tỏi, ớt, hành tím còn lại vào và phi thơm.
Tiếp theo, cho vào chảo 1.5 muỗng canh đường, 1.5 muỗng canh nước mắm rồi khuấy đều. Sau đó, cho thịt chiên vào đảo đều trên lửa trong 5 phút để thịt áo đều nước sốt.
8.Thành phẩm
Thịt ba rọi chiên nước mắm có lớp vỏ vàng ươm, giòn rụm vị bùi béo, nước sốt đậm đà với hương vị mặn ngọt. Món ăn sẽ càng thơm ngon hơn khi dùng kèm với cơm trắng đấy!'

WHERE Id = 6;

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Canh khổ qua nhồi thịt (Cho 3 người)
 - Khổ qua 3 trái
  - Thịt băm 200 gr
  - Nấm mèo 50 gr
  - Trứng vịt 1 quả
  - Nước dùng heo 800 ml
  - Hành tím 1 củ
  - Tỏi 2 tép
  - Gia vị thông dụng 1 ít
(đường/ muối/ hạt nêm/ tiêu)

Cách chế biến Canh khổ qua nhồi thịt
1.Sơ chế nguyên liệu
Khổ qua mua về bạn rửa sạch, cắt làm đôi, dùng muỗng lấy sạch phần ruột bên trong. Để khổ qua bớt đắng, bạn ngâm khổ qua trong nước lạnh 10 - 15 phút, sau đó vớt ra để ráo.
Nấm mèo ngâm nở, rửa sạch, bỏ phần chân rồi cắt nhỏ.
Đối với tỏi và hành tím, bạn lột sạch vỏ, băm nhỏ.
Hành ngò bỏ gốc, rửa sạch. Cắt hành lá thật nhuyễn để trang trí.
2.Ướp nhân và nhồi khổ qua
Trộn đều thịt với nấm mèo, hành tím, tỏi băm, 1 quả trứng vịt và các loại gia vị gồm 1 muỗng cà phê đường, 1 muỗng cà phê tiêu, 1 muỗng cà phê hạt nêm.
Để yên 10 - 15 phút cho thịt thấm đều gia vị.
Lấy một lượng nhân vừa đủ, dùng muỗng cho từ từ vào ruột khổ qua, ấn nhẹ nhàng cho nhân thật chặt.
3.Nấu khổ qua
Bắc nồi lên bếp, cho 800ml nước dùng và 1 muỗng cà phê muối, khi nước sôi cho khổ qua vào và nêm thêm 2 muỗng cà phê hạt nêm. Bạn có thể gia giảm tùy khẩu vị gia đình mình nhé.
Nấu khoảng 40 phút thì khổ qua chín mềm, tắt bếp. Bạn cho canh ra tô, rắc thêm hành ngò và 1 ít tiêu. Bạn có thể đợi cho canh nguội bớt 1 xíu rồi mới thưởng thức, khi này canh sẽ không còn đắng nữa nhé.
4.Thành phẩm
Vậy là chúng ta đã có tô canh khổ qua nhồi thịt thơm ngon, đẹp mắt và ít đắng cho cả nhà thưởng thức dịp Tết này rồi. Món ăn này rất bổ dưỡng lại còn mang ý nghĩa bỏ qua những điều xui xẻo, đón chờ những may lành mới đến. Do đó hãy nhanh nhanh vào bếp thực hiện cho gia đình mình nhé!'
WHERE Id = 7;
UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Canh gà hầm táo đỏ nấm đông cô (Cho 4 người)
 - Gà 1 con (khoảng 1 - 1.2kg)
  - Gừng nhỏ 1 củ
  - Hành boa rô 1 nhánh
  - Dầu ăn 1 muỗng canh
  - Táo đỏ 100 gr
  - Nấm đông cô khô 40 gr

Cách chế biến Canh gà hầm táo đỏ nấm đông cô
1.Sơ chế nguyên liệu
Thịt gà bạn sẽ chặt khúc vừa ăn, sau đó cho vào cái tô lớn, cho thêm khoảng 1/2 muỗng canh muối ăn rồi cho nước vào, dùng tay xoa bóp để nước máu trong thịt gà tiết ra. Cách này sẽ giúp cho nước hầm gà có màu đẹp mắt và không bị tanh.
Bạn ngâm gà trong nước muối khoảng 10 phút rồi vớt ra, rửa sạch lại với nước 2 - 3 lần, sau đó, bạn vớt thịt gà ra rổ để cho ráo nước.
Gừng thì bạn chỉ dùng 1 ít, khoảng 5 - 10gr là được. Bạn gọt vỏ gừng rồi cắt lát. Hành boa rô bạn cũng cắt lát chéo phần gốc hành (có thể thay bằng gốc hành lá).
2.Sơ chế táo đỏ và nấm đông cô
Bạn rửa sơ táo đỏ với nước để loại bỏ bụi đất. Tiếp đến, bạn dùng kéo cắt dọc trái táo đỏ theo chiều dấu chữ thập +. Như vậy, khi hầm, táo đỏ sẽ thấp nước hầm và có thể hòa tan vị ngọt tự nhiên của táo vào nước hầm.
Nấm đông cô khô bạn sẽ ngâm với nước nóng trong 10 phút cho nở rồi vớt ra, rửa lại với nước và vắt cho ráo.
3.Xào sơ thịt gà
Bắc chảo lên bếp, cho vào chảo 1 muỗng canh dầu ăn, cho tiếp phần gừng và gốc hành vào phi thơm. Tiếp đến, bạn cho thịt gà vào để xào trong khoảng 5 phút cho thịt gà săn lại hoàn toàn, da gà hơi cháy xém.
Sau đó, cho cho nước sôi vào ngập xăm xắp mặt thịt gà, đậy nắp lại, đun nhỏ lửa trong 20 phút.
4.Hầm gà
Bạn vớt hết gừng và hành trong nước dùng ra, sau đó, bạn múc thịt gà và nước dùng cho vào một cái nồi đất, cho nấm đông cô và táo đỏ vào nồi, dùng vá nhấn các nguyên liệu này chìm ngập trong nước.
Tiếp đến, bạn bắc nồi đất lên bếp, đậy nắp và hầm ở mức lửa nhỏ nhất trong 40 phút. Sau 40 phút, bạn mở nắp nồi ra, nêm thêm khoảng 1/2 muỗng cà phê muối, 1/3 muỗng cà phê hạt nêm và 1/3 muỗng cà phê đường, khuấy đều rồi nấu thêm vài phút cho gia vị tan hết thì bạn có thể tắt bếp.
5.Thành phẩm
Món gà hầm táo đỏ này không quá cầu kì, các nguyên liệu sử dụng cũng rất dễ tìm mua. Chỉ tốn một ít thời gian là bạn đã có được một nồi canh gà hầm táo đỏ nấm đông cô ngon lành ngọt nước rồi.
Món canh này không cần nêm nếm quá nhiều gia vị mà phần nước hầm vẫn có được vị ngọt thanh từ thịt gà, táo đỏ và nấm đông cô. Nấu theo cách này thì thịt gà không chỉ mềm ngon, không tanh mà nước hầm còn có màu đẹp mắt. Món này dùng để ăn với cơm hay để ăn không đều ngon.'
WHERE Id = 8;
UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Lẩu gà ớt hiểm (Cho 4 người)
 - Gà 1.2 kg (1 con)
  - Ớt hiểm 100 gr
  - Kỷ tử 5 gr
  - Sả 100 gr
  - Tỏi 20 gr
  - Hành tây 1 củ
 -  Hành tím 20 gr
  - Nước tương 2 muỗng canh
  - Dầu ăn 100 ml
  - Hạt nêm 30 gr

Cách chế biến Lẩu gà ớt hiểm
1.Sơ chế nguyên liệu
Bạn cho muối hạt và ớt hiểm vào cối, giã nhuyễn rồi chia làm 2 phần, 1 phần để ướp gà và 1 phần làm nước chấm.
Hành tím, tỏi lột vỏ, rửa sạch và băm nhỏ. Hành tây sau khi lột vỏ thì bạn rửa sạch, cắt thành múi cau, để ráo.
Sả rửa sạch, đập dập. Kỷ tử rửa sạch.
Gà sau khi làm sạch thì chặt làm 8 phần, rồi bạn cho hành tím, tỏi băm, 1/2 muỗng cà phê hạt nêm, 1 muỗng canh nước tương và ướp gà trong khoảng 15 phút.
2.Chế biến
Bắc chảo lên bếp, đun sôi 100ml dầu ăn sau đó chiên sơ sả trong dầu cho thơm rồi vớt ra, cho gà vào. Bạn chiên gà khoảng 10 phút ở lửa nhỏ cho săn lại, tới khi thịt chín vàng đều thì vớt ra.
Sau đó, bạn bắc nồi lên bếp, cho vào 2 lít nước để đun sôi, lần lượt cho hành tây, sả, gà vào nồi nước đang sôi.
Tiếp đó, cho vào nồi khoảng 100gr ớt hiểm, 30gr hạt nêm, 1 muỗng canh nước tương, nêm nếm gia vị lại cho vừa ăn. Đun hỗn hợp ở lửa vừa trong khoảng 10 phút cho đến khi gà mềm.
Khi thịt gà chín mềm thì cho tiếp kỷ tử vào nồi lẩu rồi đun tiếp trong 1 phút thì tắt bếp. Bạn có thể cho lẩu ra nồi lẩu điện để tiện lợi hơn khi thưởng thức.
3.Thành phẩm
Vị cay nồng của ớt, vị ngọt của gà, hòa quyện cùng mùi thơm nức mũi của hành tây, sả. Tất cả tạo nên một hương vị đặc trưng đậm đà khó tả. Còn gì bằng ngày mưa lành lạnh thưởng thức một chén gà tiềm ớt hiểm nóng hổi, gia đình quây quần bên mâm cơm.
Món ăn tăng thêm phần hương vị khi dùng kèm với các loại rau: mồng tơi, xà lách xoong, bún tươi hoặc mì.
Nước chấm không thể thiếu muối tiêu chanh đơn giản nhưng vô cùng chuẩn vị đấy nhé!'
WHERE Id = 9;

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Vịt nấu chao (Cho 4 người)
 - Vịt 1 con (khoảng 1.5kg)
  - Khoai môn 500 gr (2 củ)
  - Chao đỏ 350 gr (hoặc chao môn)
  - Rau muống 200 gr
  - Cải thìa 200 gr
  - Hành tím 4 củ
  - Tỏi 5 tép
  - Gừng 1 nhánh
  - Ớt sa tế 1/2 muỗng cà phê
  - Bún tươi 500 gr
  - Đường phèn 3 muỗng canh
  - Dầu ăn 7 muỗng canh
  - Dầu màu điều 2 muỗng canh
  - Gia vị thông dụng 1 ít
(Muối/ hạt nêm/ đường/ bột ngọt)

Cách chế biến Vịt nấu chao
1.Sơ chế nguyên liệu
Để khử mùi hôi của thịt vịt, bạn chà xát 1 muỗng canh muối lên bề mặt thịt vịt, rồi rửa thật sạch với nước. Sau đó, chặt thành khúc nhỏ vừa ăn, để ra rổ cho ráo nước.
Khoai môn bạn dùng dao gọt bỏ đi lớp vỏ rồi rửa sạch và cắt thành các miếng vừa ăn có chiều dài khoảng 2 lóng tay.
Hành tím và tỏi, gừng bạn bỏ vỏ, rửa sạch rồi băm nhỏ. Rau muống và rau cải thìa bạn nhặt bỏ gốc già, lá úa, rửa sạch rồi cắt khúc vừa ăn khoảng 2 lóng tay.
Bạn lấy 200gr khoai môn đã sơ chế cho vào máy xay sinh tố, thêm 200ml sữa tươi không đường rồi xay nhuyễn mịn.
2.Ướp vịt
Bạn lấy 300gr chao đỏ và 2 muỗng canh nước của chao ra chén, thêm 3 muỗng canh đường, 2 muỗng canh dầu màu điều, 2 muỗng canh bột ngọt, dùng muỗng nghiền nhuyễn.
Bạn ướp vịt với hỗn hợp chao và 1/2 phần hành tím băm, 1/2 phần tỏi băm. Trộn đều và để ướp thịt vịt trong khoảng 2 tiếng cho thấm gia vị.
3.Chiên khoai môn
Bắc chảo lên bếp mở lửa vừa, cho vào chảo 5 muỗng canh dầu ăn, đợi dầu nóng thì bạn cho phần khoai môn còn lại vào chiên.
Bạn chỉnh lửa nhỏ và chiên khoảng 5 phút cho khoai môn vàng đều cả 2 mặt thì bạn gắp ra để ráo dầu.
4.Làm vịt nấu chao
Bắc nồi lên bếp mở lửa vừa, cho vào nồi 2 muỗng canh dầu ăn, đợi dầu nóng thì bạn cho phần hành tím, tỏi còn lại và 1 muỗng canh gừng băm vào, phi thơm lên.
Khi hành tím, tỏi đã thơm, bạn cho thịt vịt vào, xào khoảng 10 phút ở lửa lớn cho thịt vịt săn lại rồi bạn cho hỗn hợp khoai môn xay nhuyễn vào xào thêm 10 phút ở lửa vừa.
Sau đó, bạn cho 2 lít nước, 3 muỗng canh đường phèn, 4 muỗng canh hạt nêm vào, chỉnh lửa nhỏ đậy nắp nấu thêm 30 phút.
Sau cùng, bạn thêm nấm rơm, khoai môn đã chiên vào, đợi sôi lại bạn nêm nếm cho hợp khẩu vị gia đình là hoàn thành rồi nè!
5.Làm nước chấm
Bạn lấy 50gr chao (khoảng 2 viên) và 4 muỗng canh nước của chao ra chén, dùng muỗng nghiền nhuyễn rồi thêm 1/2 muỗng cà phê ớt sa tế vào là hoàn thành nước chấm.
6.Thành phẩm
Vịt nấu chao sau khi hoàn thành có màu sắc đẹp mắt, mùi thơm hấp dẫn lan tỏa cả căn phòng.
Khi ăn bạn cho bún tươi ra chén, ăn tới đâu nhúng kèm rau muống, rau cải thìa tới đó, phần thịt vịt thơm, béo mềm, thấm đẫm gia vị vừa ăn, chấm kèm chén chao, chắc chắn sẽ khiến gia đình bạn thích mê chỉ với miếng đầu tiên.'
WHERE Id = 10;
UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Cá lóc kho tộ (Cho 2 người)
 - Cá lóc 1 con (khoảng 500gr)
 - Thịt heo xay 50 gr
 - Nước dừa 1 trái
  - Gia vị thông dụng 1 ít
(Muối/ hạt nêm/ đường/ bột ngọt)

Cách chế biến Cá lóc kho tộ
1.Sơ chế cá lóc
Cá lóc đem rửa sạch, làm thịt, bỏ mang, cắt khúc vừa ăn, để ráo nước.
2.Ướp cá
Phần đầu hành lá băm nhuyễn, trộn đều với 2 thìa nước mắm, 1 thìa nước màu, 1 thìa nhỏ tiêu xay, 1 thìa nhỏ hạt nêm sau đó ướp đều hỗn hợp lên cá trong 30 phút.
3.Kho cá
Bắc nồi đất lên bếp cho nóng, phi một ít tỏi băm, hành phi với dầu ăn cho vàng, thơm.
Cho thịt heo xay vào đảo đều, đến khi vàng đều thì cho cá đã ướp + phần nước ướp cá + nước dừa tươi vào đun lửa vừa.
Đến khi nước cạn còn 1/2 thì giảm lửa nhỏ nhất, nêm nếm lại gia vị cho vừa ăn, đun liu riu đến khi nước trong nồi sệt lại, thịt cá săn chắc là được.
4.Thành phẩm
Thịt cá chín đều có màu vàng sậm, săn chắc, dậy mùi thơm nồng. Bạn có thể dùng thêm ớt hiểm, hành lá để trang trí cho bắt mắt hoặc để ăn kèm.
Món cá lóc kho tộ ăn nóng với cơm rất ngon, chắc chắn sẽ mang lại cho bạn bữa cơm đầm ấm bên gia đình. Chúc bạn thành công!'
WHERE Id = 11;

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU: Bắp xào bơ (Cho 2 người)
  - Bắp 3 trái
  - Hành lá 2 nhánh
  - Ớt băm 1/4 muỗng cà phê
 -  Hành phi 1 muỗng canh
  - Bơ 1 muỗng cà phê
  - Nước mắm 2 muỗng cà phê
  - Dầu ăn 2 muỗng canh
 -  Gia vị thông dụng 1 ít
(hạt nêm/ đường/ muối/ bột ngọt)

Cách chế biến Bắp xào bơ
1.Sơ chế bắp và các nguyên liệu
Bắp sau khi mua về, bạn lột sạch vỏ và râu bắp, rửa thật sạch với nước. Dùng dao để tách hạt bắp theo hàng, rửa lại cho sạch râu bắp rồi để ráo.
Hành lá sau khi mua về, bạn bỏ gốc và lá già úa, rửa sạch, để ráo rồi cắt nhỏ
2.Hấp bắp
Bắc nồi lên bếp, cho nước vào đun sôi, nước sôi bạn đặt xửng hấp vài bên trong nồi.
Cho bắp lên xửng, đậy nắp, hấp cách thủy khoảng 6 phút với lửa vừa.
Bắp chín, bạn cho bắp ra dĩa hoặc tô.
3.Xào bắp
Bắc chảo lên bếp, đun nóng 2 muỗng canh dầu ăn, cho 1/3 phần hành lá đã cắt nhỏ vào phi thơm.
Hành thơm, bạn cho bắp vào, nêm vào đó 1 muỗng cà phê hạt nêm, 2 muỗng cà phê nước mắm, 1 muỗng cà phê đường. Xào với lửa vừa trong 3 phút.
Tiếp theo bạn cho tất cả phần hánh lá còn lại vào, thêm 1 muỗng cà phê bơ, 1/2 muỗng canh hành phi và 1 ít ớt nếu bạn muốn ăn cay. Xào thêm 3 phút, bạn có thể nêm nếm lại cho vừa ăn rồi tắt bếp.
4.Thành phẩm
Khi ăn bạn cho bắp ra dĩa hoặc chén, thêm chút hành phi là hoàn thành rồi đấy. Bắp xào bơ một món ăn chơi tuy đơn giản nhưng lại rất ngon miệng, thích hợp trong các buổi ăn vặt cùng bạn bè và gia đình. Bắp giòn, ngọt, màu vàng tươi hấp dẫn, thơm phức mùi bơ và hành phi. Cùng vào bếp ngay nhé!'
WHERE Id = 13;

UPDATE Recipes 
SET RecipeDetail = N'NGUYÊN LIỆU:  Hột vịt lộn xào me (Cho 2 người)
• Trứng vịt lộn 5 quả
• Me vắt 40 gram
• Đậu phộng 50 gram
• Rau răm 50 gram
• Tỏi 5 tép
• Ớt 2 trái
• Dầu ăn 2 muỗng canh
• Nước mắm 3 muỗng canh
• Muối/ đường 1 ít
Cách chọn
1. Mua hột vịt lộn tươi ngon
Hột vịt lộn ngon thì vỏ ngoài thường dính 1 ít cám, cầm lên thấy nặng tay.
Bạn cũng có thể thử bằng cách mà soi dưới ánh sáng. Nếu phần đầu trứng không bị khoảng trống nhiều, phần ruột trứng đầy lên thì đó là trứng ngon.
Không nên chọn mua trứng quá nhẹ, vỏ nổi mốc và khi lắc thì nghe thấy tiếng động vì đó là những quả hỏng.
2. Mua đậu phộng tươi ngon
Nên lựa những hạt to, tròn, vỏ bên ngoài có màu sáng. Bấm vào có cảm giác chắc tay.
Hạt đều, không bị trộn lẫn chung những hạt lép, hư thối, bị mọt.
Không mua đậu phộng có mùi lạ hoặc dấu hiệu lạ bên ngoài hạt đậu.
Cách chế biến:
Hột vịt lộn xào me
1.Sơ chế nguyên liệu
Luộc 5 quả trứng vịt lộn với thời gian 20 phút ở lửa lớn. Sau đó vớt trứng để vào trong nước lạnh, tiến hành lột vỏ và phân riêng ra phần trứng và phần nước hột vịt lộn.
Bắc chảo lên bếp cùng 1 muỗng cà phê muối và cho phần đậu phộng vào rang ở lửa nhỏ khoảng 5
• 7 phút cho đến khi phần vỏ lụa nứt và dậy mùi thơm thì tắt bếp. Để đậu nguội và tiến hành bóc bỏ vỏ lụa.
Rau răm rửa sạch, để ráo, 1 nửa cắt nhỏ, 1 nửa để nguyên. Tỏi bóc vỏ, băm nhỏ. Ớt rửa sạch, cắt lát.
2.Làm nước sốt me
Cho me vắt ra một cái tô với 150ml nước sôi, dầm me rồi lược qua rây và lấy nước cốt.
Cho vào nước cốt me phần nước trứng vịt lộn, 3 muỗng canh đường, 3 muỗng canh nước mắm và 1/3 muỗng cà phê muối rồi khuấy đều cho gia vị hòa tan.
3.Nấu nước sốt me
Bắc chảo lên bếp, cho vào 2 muỗng canh dầu ăn và phi thơm phần tỏi băm. Sau khi tỏi đã thơm thì bạn cho phần nước sốt me vào xào trên lửa lớn khoảng 3 phút rồi cho phần ớt cắt lát vào. Nêm nếm lại cho hợp khẩu vị và xào thêm khoảng 2 phút nữa.
4.Xào hột vịt với me
Cho hột vịt lộn vào chảo nước sốt và xào, rưới đều nước sốt lên trứng cho thấm gia vị. Nấu trên lửa vừa 10 phút cho nước sốt áo đều lên trứng và sền sệt lại.
Cuối cùng cho rau răm cắt nhỏ vào rồi tắt bếp. Cho hột vịt lộn xào me ra dĩa, trang trí rau răm và rắc đậu phộng rang lên và thưởng thức.
THÀNH PHẨM
Món này ăn nóng là ngon nhất, hột vịt lộn vừa chua chua vừa ngọt ngọt rất đậm đà lại còn chứa rất nhiều chất dinh dưỡng tốt cho sức khỏe, đảm bảo sẽ làm gia đình bạn thích mê đấy.'

WHERE Id = 14; 

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Nui xương heo thập cẩm', 
    '/images/nuixuongheo.jpg', 
    N'Nui xương heo thập cẩm đơn giản hấp dẫn, đổi vị cho gia đình', 
    N'NGUYÊN LIỆU: Nui xương heo thập cẩm (Cho 3 người)
 Xương heo 700 gr
 Nui 500 gr
 Tôm 10 con
 Mọc 300 gr
 Cà rốt 1 củ
 Cải trắng 1 củ
 Hành lá cắt nhỏ 1 ít
 Trứng gà 4 quả
 Dầu ăn 2 muỗng canh
 Nước mắm 1 muỗng canh
 Gia vị thông dụng 1 ít
(muối/ đường/ bột ngọt/ hạt nêm/ tiêu)
Cách chọn
Mua nguyên liệu tươi ngon:
1. Cách chọn mua xương heo tươi ngon
Lựa chọn xương có kích cỡ to vừa phải và ít mỡ.
Xương heo ngon thường có màu tươi, không bị tái cũng như không có mùi lạ.
Nhiệt độ của xương khi mua cũng ảnh hưởng đến độ ngon của xương, không chọn loại xương bị lạnhcấp đông vì có thể loại xương này đã được bảo quản lâu, không còn tươi mới.
2. Cách chọn mua tôm tươi ngon
Bạn nên chọn tôm còn sống, bơi khỏe, có lớp vỏ ngoài trong suốt còn hơi mùi của nước biển có phần chân gắn chặt vào thân.
Tôm tươi thường sẽ có phần đuôi xếp lại với nhau. Nếu đuôi tôm xòe ra thì tôm đã bị bơm hóa chất hoặc tiêm nước làm cho tôm mập mạp, không nên mua nhé!
Ngoài ra bạn cũng không nên chọn những con tôm có hiện tượng chảy nhớt, thân hình đã uốn cong thành hình tròn không còn thẳng như bình thường. Khi dùng tay nhấn nhẹ và di chuyển trên vỏ tôm thấy cộm như có sạn trong vỏ.
Để yên tâm khi lựa chọn bạn nên chọn mua tôm ở các cửa hàng bán hải sản uy tín để tránh mua nhầm tôm bị bơm hóa chất nhé!
3. Cách chọn mua mọc (giò sống) ngon
Khi chọn mua mọc bạn nên chú ý đến ngày sản xuất và hạn sử dụng in trên bao bì sản phẩm.
Chọn mua mọc khi thấy giò có màu trắng ngà, tươi sáng. Mọc mới sẽ có mùi thịt mỡ đặc trưng, không có mùi lạ.
Không mua mọc khi thấy xuất hiện những đốm đen lạ.
Cách chế biến
Nui xương heo thập cẩm
1. Sơ chế các nguyên liệu
Để khử mùi hôi và làm sạch xương heo, sau khi mua về bạn đem chần sơ qua nước sôi có pha ít muối trong khoảng 2 phút, sau đó vớt ra rửa sạch với nước lạnh rồi để ráo.
Cắt bỏ đầu tôm, rửa sạch rồi để cho thật ráo.
Cà rốt và củ cải rửa sạch, gọt vỏ, sau đó cắt thành khoanh vừa ăn.
2. Ướp thịt
Cho xương heo ra 1 cái tô, nêm vào đó 1 muỗng cà phê muối, 1 muỗng cà phê bột ngọt, 1 muỗng canh đường, 1 muỗng canh hạt nêm cùng 1/2 muỗng cà phê tiêu. Trộn đều rồi ướp xương trong vòng 10 - 15 phút để xương thấm gia vị.
3. Nấu nước dùng
Bắc nồi lên bếp, cho vào nồi 2 muỗng canh dầu ăn. Đợi dầu nóng thì cho xương heo vào xào trong 3 - 5 phút đến khi thịt săn lại. Tiếp đến, đổ thêm vào nồi 2 lít nước, cho củ cải vào hầm trước trong 20 phút sau đó cho cà rốt vào.
Nấu đến khi nước trong nồi sôi lên thì cho mọc và tôm vào nấu thêm 10 phút nữa.
Sau đó, nêm nếm nước dùng với 1 muỗng canh đường, 1 muỗng canh nước mắm, 1 muỗng cà phê muối, 1 muỗng cà phê tiêu và 1 muỗng cà phê hạt nêm.
4. Luộc nui và trứng
Bắc 1 nồi nước lên bếp nấu sôi, sau đó cho nui vào luộc trong khoảng 5 - 8 phút, nếu muốn ăn nui mềm hơn, bạn luộc nui thêm 5 phút nữa. Để khi luộc nui không bị dính, bạn thêm vào một ít dầu ăn. Khi nui đã chín thì đổ ra rổ, xả qua nước lạnh, để ráo.
Tiếp tục bắc 1 nồi nước khác lên bếp rồi cho trứng vào luộc trong 7 - 10 phút. Khi trứng chín thì vớt ra cho vào 1 tô nước lạnh để trong 1 - 2 phút rồi đem trứng bóc vỏ.
5. Hoàn thành
Cho nui cùng trứng gà ra tô, sau đó múc nước và cho cùng xương heo, tôm, củ cải, cà rốt lên trên. Thêm ít hành lá và 1 ít tiêu nữa, vậy là món ăn đã hoàn thành. Còn chần chừ gì nữa, chuẩn bị thưởng thức thôi nào!
THÀNH PHẨM
Tô nui với xương heo sẽ thu hút bạn ngay muỗng nước dùng nóng hổi đầu tiên nhờ vị ngọt thanh tự nhiên của nui và xương heo, kết hợp cùng tôm, mọc, cà rốt và củ cải. Món này bạn có thể ăn sáng hoặc ăn vào bữa chính đều được nhé.',
1
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Bánh canh Quy Nhơn', 
    '/images/banhcanhchaca.jpg', 
    N'Cách nấu bánh canh chả cá Nha Trang, Quy Nhơn ngon đúng vị', 
    N'NGUYÊN LIỆU: Bánh canh Quy Nhơn (Cho 4 người)
 Sợi bánh canh 500 gr
 Cá thu 400 gr
 Thịt tôm 50 gr (làm sẵn)
 Thịt cua 50 gr (làm sẵn)
 Nấm 200 gr
 Trứng cút 15 quả
 Hành lá 3 nhánh
 Ngò 3 nhánh
 Hành tây 1/2 củ
 Hành tím 2 củ
 Tỏi 3 tép (băm nhuyễn)
 Ớt tươi 2 trái
 Rau sống 300 gr
 Nước lọc 500 ml
 Nước mắm 1 muỗng canh
 Dầu ăn 230 ml
 Gia vị thông dụng 1 ít
(Tiêu xay/ muối/ đường)
Cách chế biến
Bánh canh Quy Nhơn
1.Sơ chế nguyên liệu
Cá mua về bạn tiến hành làm sạch cá rồi dùng giấy thấm hết phần nước bên ngoài cá. Sau đó, dùng muỗng nạo hết phần thịt cá. Phần xương cá và đầu cá cho ra tô (dùng để cho vào nồi nước dùng).
Nấm ngâm với nước ấm cho nở khoảng 10 phút rồi sau đó vớt ra, cắt đôi. Trứng cút luộc chín, bóc vỏ.
Bạn cho chỗ thịt cá đã nạo vào tô trộn cùng 2 muỗng canh dầu ăn, thêm tỏi, hành lá vào. Tiếp đó nêm thêm 1 muỗng canh đường, 1/2 muỗng canh muối, 1 muỗng canh mắm rồi ướp trong vòng 1 giờ.
Chần bánh canh qua nước sôi từ 2 - 3 phút rồi sau đó xả ngay vào nước lạnh để sợi bánh được tơi mà không bị nát và dính vào nhau.
Hành tây và hành tím lột bỏ vỏ rồi rửa sạch với nước và để ráo. Hành lá và ngò rửa sạch rồi cắt nhỏ.
2.Nấu nước dùng
Bắc nồi lên bếp, cho vào nồi khoảng 500 lít nước lọc rồi đun sôi. Sau đó, cho xương cá với hành tím, hành tây, trứng cút vào hầm chung với nhau.
Nêm thêm 1/2 muỗng canh muối, 1 muỗng canh đường phèn vào nồi và nấu cho đến khi xương và đầu cá đều chín nhừ.
Khoảng 35 - 40 phút sau khi hầm xương, lọc lấy phần nước lèo trong, phần xương cá không dùng nữa bạn bỏ đi.
Phần cá sau khi ướp cùng với thịt tôm và cua bạn cho vào cối đánh mịn, sờ có cảm giác dính tay là được.
3.Làm chả cá
Thoa một chút dầu vào lòng bàn tay rồi cho hỗn hợp cá ra tay, vo tròn thành các miếng có kích thước tương đối.
Bắc chảo lên bếp, cho vào chảo 200ml dầu ăn. Chờ dầu sôi, bạn cho miếng cá vào chiên đến khi vàng giòn cả 2 mặt thì vớt ra để ráo dầu.
4.Hoàn thành
Gắp bánh canh ra tô, đặt chả cá, trứng cút lên trên phần bánh canh rồi chan nước dùng vào, rắc thêm hành ngò.
Đặt bên cạnh ít rau sống đã cắt nhuyễn cùng một chén nước mắm ớt Bình Định để ăn cùng với bánh canh nữa là hoàn chỉnh món ăn.
THÀNH PHẨM
Khi ăn, bạn sẽ cảm nhận được độ mềm của sợi bánh cánh, độ dai dai của chả cá và một vị ngọt thanh vừa miệng của nước dùng. Còn chần chờ gì nữa mà không nhanh tay thưởng thước thành quả của mình đi nào!',
1
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Sườn xào chua ngọt', 
    '/images/suonxaochuangot.jpg', 
    N'Cách làm sườn xào chua ngọt bằng chanh thơm mềm, bắt vị cho bữa cơm nhà', 
    N'NGUYÊN LIỆU: Sườn xào chua ngọt bằng chanh (Cho 2 - 3 người)
 Sườn non 0.5 kg
 Hành 1 củ
 Tỏi 1 củ
 Chanh 1 quả
 Gia vị thông dụng 1 ít
(nước mắm/ đường/ bột canh/ muối hạt/ nước lọc)
Cách chế biến
Sườn xào chua ngọt bằng chanh
1.Sơ chế sườn non đúng cách
Đầu tiên, bạn chuẩn bị một nồi nước nóng, cho vào đó một ít muối hạt rồi hòa tan. Cho sườn non vào rửa sơ, sau đó đun thêm khoảng 2 - 3 phút cho nước sôi để sườn bớt mùi hôi.
Tắt bếp, vớt sườn ra và rửa sạch lại dưới vòi nước chảy đến khi thấy nước rửa trong là sườn đã sạch.
2.Ướp và hầm sườn non mềm ngon
Cho sườn đã sơ chế vào nồi, thêm 1/4 thìa phở bột canh, 1/2 thìa phở đường và một ít nước lọc (vừa đủ ngập sườn).
Đun lửa to cho sườn sôi, sau đó đảo đều để gia vị ngấm.
Đậy vung, chỉnh lửa nhỏ và đun khoảng 15 phút. Thỉnh thoảng đảo đều để sườn ngấm gia vị và mềm đều. Việc đun nhỏ lửa sẽ giúp sườn mềm mại, không bị dai khi xào.
3.Pha nước sốt chua ngọt bằng chanh tươi
Trong lúc chờ sườn mềm, bạn chuẩn bị nước sốt. Cho vào bát 1 thìa phở nước mắm, 1 thìa phở đường, 1 thìa phở nước cốt chanh tươi và 2 thìa phở nước lọc.
Khuấy đều hỗn hợp cho đường tan hoàn toàn. Đây chính là linh hồn của món sườn chua ngọt bằng chanh.
4.Làm nước màu và hoàn thiện sốt chua ngọt
Để món sườn có màu sắc đẹp mắt, bạn làm nước màu. Cho vào một chiếc chảo nhỏ 2/3 thìa phở đường và một ít nước. Đun nhỏ lửa đến khi đường tan chảy và chuyển sang màu vàng cánh gián đẹp mắt.
Sau đó, đổ bát nước sốt chua ngọt đã pha vào chảo nước màu, khuấy đều cho hòa quyện. Tắt bếp và đổ ra bát.
5.Xào sườn với nước sốt chua ngọt đậm đà
Khi sườn đã hầm mềm và nước cạn, bạn mở vung và tiếp tục đun thêm một lúc nữa để sườn hơi vàng và ra bớt mỡ.
Cho hành tỏi băm vào chảo sườn, đảo đều cho thơm.
Đổ bát nước sốt chua ngọt đã chuẩn bị vào chảo sườn, đảo đều. Đun nhỏ lửa khoảng 5 phút để sườn ngấm đều nước sốt. Khi nước sốt sánh lại, bám đều vào từng miếng sườn là đạt yêu cầu.
THÀNH PHẨM
Món sườn xào chua ngọt bằng chanh đã hoàn thành với màu sắc vàng óng, đẹp mắt. Miếng sườn mềm tan, không hề bị dai, quyện cùng vị mặn, ngọt, chua hài hòa từ nước sốt chanh tươi. Mùi thơm của hành tỏi phi dậy lên hấp dẫn, đảm bảo sẽ làm hài lòng cả gia đình bạn.',
2
);


INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Gà xào gừng sả', 
    '/images/gaxaogung.jpg', 
    N'Cách làm gà xào gừng sả thơm nức mũi, cực kỳ đưa cơm cho cả gia đình', 
    N'NGUYÊN LIỆU: Gà xào gừng sả (Cho 4 người)
 Thịt gà ta 1 kg (chặt miếng vừa ăn)
 Gừng 1 ít (thái sợi hoặc lát)
 Sả 3 nhánh (thái lát)
 Ớt 3 trái (thái lát)
 Hành tím băm 1 ít
 Lá chanh 1 ít (thái sợi)
 Gia vị thông dụng 1 ít
(muối/ hạt nêm/ tiêu xay/ đường/ nước tương/ dầu ăn)
Cách chọn
Mua thịt gà tươi ngon
Nên chọn mua gà có lớp da mỏng, mịn, màu vàng nhạt tự nhiên và những vùng như ức hay cánh thường có màu vàng đậm hơn.
Bạn hãy ưu tiên những con gà có phần thịt săn chắc, khi ấn nhẹ tay vào miếng thịt thấy có độ đàn hồi tốt và không bị nhão.
Hãy chọn những miếng thịt gà có màu hồng tươi sáng, trông bóng sạch, bề mặt khô ráo và tỏa ra mùi đặc trưng của gia cầm.
Tránh mua thịt gà có màu trắng bệch, xuất hiện các nốt đen lạ, vết tụ máu bầm tím hoặc có dấu hiệu chảy nhớt và mùi hôi khó chịu.
Cách chế biến
Gà xào gừng sả
1.Sơ chế nguyên liệu và khử mùi tanh thịt gà
Bạn mang 1kg thịt gà đi rửa thật sạch. Để khử mùi hôi đặc trưng, bạn dùng hỗn hợp muối, chanh và gừng đập dập chà xát kỹ lên toàn bộ phần thịt gà, sau đó rửa lại dưới vòi nước sạch và chặt thành từng miếng mỏng vừa ăn.
2.Ướp gia vị kho gà đậm đà
Bạn cho thịt gà đã sơ chế vào một thau lớn, nêm vào 1 muỗng cà phê muối, 1 muỗng cà phê hạt nêm, 1/2 muỗng cà phê tiêu xay, 1 muỗng cà phê đường và 3 muỗng canh nước tương.
Bạn trộn thật đều tay và để thịt gà nghỉ trong khoảng 20 phút cho thấm gia vị.
3.Xào thịt gà
Bạn bắc chảo lên bếp cùng một ít dầu ăn. Khi dầu nóng, bạn cho hành tím băm, gừng thái sợi, sả thái lát và ớt cắt nhỏ vào phi cho thật thơm. Tiếp theo, bạn cho toàn bộ phần thịt gà đã ướp vào xào ở lửa lớn cho đến khi thịt gà săn lại, hơi tiết nước.
Sau đó, bạn đậy nắp chảo và để lửa nhỏ riu riu trong khoảng 10 phút để gà chín mềm từ bên trong.
THÀNH PHẨM
Món gà xào gừng sả đạt yêu cầu sẽ có mùi thơm nồng nàn của sả và lá chanh. Thịt gà thấm vị mặn ngọt hài hòa, có chút cay nồng của ớt và ấm nóng của gừng, ăn cùng cơm trắng nóng hổi là ngon nhất.',
2
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Nấm xào thập cẩm', 
    '/images/namxaothapcam.jpg', 
    N'Cách làm món nấm xào thập cẩm đơn giản thơm ngon ai cũng thích', 
    N'NGUYÊN LIỆU: Nấm xào thập cẩm (Cho 2-3 người)
 Nấm kim châm 2 gói
 Nấm bào ngư 1 gói
 Nấm đùi gà 1 gói
 Nấm hương 1 cái
 Cà rốt 1/2 củ
 Hẹ 6 cây
 Hành tím 4 củ
 Mè rang 1 ít
 Gia vị thông dụng 1 ít
(nước tương/tiêu/muối/dầu ăn)
Cách chọn
 Mua nguyên liệu tươi ngon
1.Mua nấm kim châm:
Nấm kim châm tươi ngon có màu trắng sáng, trắng tinh hoặc trắng ngà đồng đều, không vàng ố hay đốm đen bất thường.
Thân nấm phải thẳng, chắc chắn, không mềm nhũn, rã rời hay chảy nhớt. Mũ nấm tròn đều, chắc, không dập nát và dính chặt vào thân.
Gói nấm phải kín đáo, khô ráo, không đọng hơi nước. Nấm có mùi thơm đặc trưng, thoang thoảng của đất, không có mùi lạ.
2.Mua nấm bào ngư:
Chọn nấm bào ngư có thân chắc, thon dài, mập và dai. Mũ nấm to, tròn đều, không bị rách nhiều hoặc vỡ vụn.
Màu sắc tươi sáng và tự nhiên, không thâm đen hay bầm tím trên tai nấm. Nấm thường mọc thành từng cụm, trông tươi rói.
Nấm cầm nặng tay, khô ráo, không bị chảy nước, nhớt hoặc có cảm giác dính tay. Mùi thơm đặc trưng, không mùi hôi lạ.
3.Mua nấm đùi gà:
Nấm đùi gà tươi có hình dáng cân đối, thân thẳng, không cong vẹo. Bề mặt nấm phải khô ráo, không ẩm ướt hay dính nhớt.
Lớp tơ mỏng mịn như nhung trên mũ nấm là dấu hiệu nấm vừa thu hoạch, còn giữ trọn độ tươi. Cầm nấm chắc và nặng tay.
Chiều dài lý tưởng là 12-15cm, thớ thịt trắng mịn khi cắt. Nấm có mùi hạnh nhân thoang thoảng, không mùi hăng hay chua.
Cách chế biến
Nấm xào thập cẩm
1.Sơ chế nấm
Với nấm kim châm, bạn cắt bỏ phần gốc.
Nấm bào ngư và nấm đùi gà thì xé nhỏ hoặc thái lát nếu nấm quá to. Cắt bỏ phần gốc cứng.
Nấm hương thì cắt bỏ phần cuống.
Mách nhỏ: Đảm bảo sơ chế nấm sạch sẽ, loại bỏ phần gốc già và dập nát để món ăn ngon hơn.
Cho tất cả nấm đã sơ chế vào thau, thêm nước và ngâm với nước muối loãng khoảng 5 phút.
Sau đó, vắt nấm thật ráo nước. Đây là bước quan trọng để nấm không bị ra nước khi xào và thấm gia vị tốt hơn.
2.Ướp nấm xào chay thập cẩm
Cho nấm đã vắt ráo vào thau. Ướp với 1 muỗng nước tương, 1 muỗng tiêu và một chút muối (gia giảm tùy khẩu vị).
Đập dập, băm nhỏ hành tím. Cho phân nửa hành tím vào ướp cùng nấm. Trộn đều và để nấm thấm gia vị.
3.Sơ chế rau củ
Cà rốt (củ cải đỏ) gọt vỏ, rửa sạch, thái lát mỏng rồi thái sợi dài vừa ăn.
Hẹ rửa sạch, cắt thành các đoạn nhỏ vừa ăn, dài tương đương sợi cà rốt.
4.Rang mè
Cho mè vào chảo, rang với lửa nhỏ cho đến khi mè vàng thơm. Sau đó, tắt bếp và để riêng.
Mách nhỏ: Rang mè sẽ giúp món ăn dậy mùi thơm và hấp dẫn hơn.
5.Xào nấm thập cẩm
Đặt chảo lên bếp, cho một ít dầu ăn vào. Khi dầu nóng, cho phần hành tím còn lại vào phi thơm. Lưu ý không phi quá vàng.
Khi hành tím dậy mùi, cho toàn bộ phần nấm đã ướp vào chảo. Xào nhanh tay khoảng 2-3 phút cho nấm săn lại và chín tới.
Tiếp theo, cho cà rốt đã thái sợi vào xào cùng nấm.
Thêm 1 muỗng mè rang vào chảo (có thể thêm nhiều hơn nếu thích). Tiếp tục xào thêm vài phút cho cà rốt vừa chín tới. Đảo liên tục để cà rốt chín đều.
Cuối cùng, cho hẹ vào xào nhanh khoảng 30 giây đến 1 phút cho hẹ vừa héo là được.
THÀNH PHẨM
Tắt bếp và bày món nấm xào thập cẩm ra đĩa. Món ăn nóng hổi, thơm lừng với đủ màu sắc bắt mắt từ nấm, cà rốt và hẹ.',
2
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Tóp mỡ da giòn', 
    '/images/topmo.jpg', 
    N'Cách làm tóp mỡ da giòn lâu không bị ỉu', 
    N'NGUYÊN LIỆU: Tóp mỡ da giòn (Cho 1 kg mỡ da heo)
 Mỡ da heo 1 kg
 Muối 1 muỗng cà phê
 Nước mắm 2 muỗng cà phê
 Đường 3 muỗng cà phê
 Tỏi 1 ít
 Hành tím 1 ít
 Ớt 3 trái
Cách chọn
Mua mỡ da heo tươi ngon:
Ưu tiên da có độ dày vừa phải, dính lớp mỡ mỏng 0.5 - 1 cm. Chọn da từ mỡ gáy hoặc mỡ vai để tóp mỡ giòn xốp và thơm hơn.
Da heo tươi có màu trắng hồng hoặc hồng hào, sáng bóng. Ấn nhẹ vào da sẽ thấy săn chắc và nhanh chóng đàn hồi trở lại.
Da tươi có mùi thơm nhẹ đặc trưng, không có mùi hôi tanh. Bề mặt da phải khô ráo, không nhớt hay có dịch lỏng bất thường.
Luôn mua da heo tại các siêu thị, cửa hàng uy tín có chứng nhận vệ sinh an toàn thực phẩm để đảm bảo chất lượng.
Cách chế biến
Tóp mỡ da giòn
1.Sơ chế da heo
Đầu tiên, bạn chuẩn bị 1kg mỡ da heo. Hãy cạo rửa thật sạch với nước giấm và muối, đảm bảo loại bỏ hết lông và bụi bẩn.
Rửa lại nhiều lần với nước sạch rồi để ráo hoàn toàn. Đây là bước quan trọng để tóp mỡ thơm ngon, không còn mùi hôi.
Cho phần mỡ da heo đã sơ chế vào nồi, đổ nước vừa ngập miếng da. Thêm vài củ hành tím đập dập vào luộc cùng để khử mùi hôi. Tính từ lúc nước sôi, luộc khoảng 6 phút rồi tắt bếp.
Vớt mỡ ra, rửa lại một lần nữa với nước sạch và để thật ráo.
Khi mỡ đã ráo, dùng dao cắt thành từng miếng vuông nhỏ vừa ăn. Lưu ý đừng cắt quá nhỏ vì tóp mỡ sẽ teo lại khi thắng. Kích thước khoảng 2x2cm là lý tưởng.
2.Thắng tóp mỡ lần 1
Cho phần mỡ đã cắt vào chảo, thêm khoảng 1/3 chén nước lọc. Bật lửa riu riu và bắt đầu thắng. Lúc này, bạn không cần đảo liên tục, thỉnh thoảng đảo đều để mỡ ra đều. Việc cho nước vào sẽ giúp mỡ ra nhiều hơn và tóp mỡ giòn hơn.
Khi mỡ đã ra nhiều, ngập gần hết tóp mỡ, cho một ít tỏi đã cắt đôi (tỏi lớn) hoặc để nguyên tép (tỏi nhỏ) vào để tóp mỡ và mỡ thơm hơn.
Khi thấy phần da bắt đầu trắng và mỡ đã ra rất nhiều, hãy vớt hết phần mỡ nước ra riêng để dùng dần. Lúc này tóp mỡ chưa giòn đâu nhé!
3.Ướp muối và thắng tóp mỡ lần 2
Để tóp mỡ nguội bớt, cho vào 1 muỗng cà phê muối rồi xóc đều. Muối sẽ giúp tóp mỡ giòn hơn khi thắng lại.
Trước khi thắng lần 2, nhớ gắp bỏ hết phần xác tỏi đã phi ra khỏi chảo để tránh bị cháy khét.
Cho tóp mỡ đã ướp muối ngược lại chảo, tiếp tục thắng trên lửa riu riu. Lúc này, bạn sẽ thấy phần da bắt đầu nổi cốm lên, phồng to và nhẹ hơn. Đây là dấu hiệu tóp mỡ đã giòn rụm, vàng ươm.
Mách nhỏ: Luôn để lửa nhỏ để tóp mỡ giòn đều, không bị cháy và đặc biệt là không bị bắn dầu.
4.Vớt tóp mỡ và làm sốt tỏi ớt mắm đường
Khi tóp mỡ đã đạt độ giòn mong muốn, vớt ra rây lọc dầu để ráo bớt dầu thừa.
Trong một chảo khác (hoặc dùng lại chảo đã làm sạch), cho khoảng 4 tép tỏi đâm nhuyễn vào phi thơm vàng giòn. Vớt tỏi phi ra để riêng.
Trong chảo còn lại dầu tỏi, cho 3 muỗng cà phê đường và 2 muỗng cà phê nước mắm vào. Đun nhỏ lửa cho đường và nước mắm tan đều.
Mách nhỏ: Lượng đường nhiều hơn nước mắm một chút vì tóp mỡ đã có vị mặn từ muối.
5.Hoàn thành món tóp mỡ da giòn sốt tỏi ớt
Khi sốt đường nước mắm vừa sánh nhẹ, cho tóp mỡ đã thắng giòn vào đảo đều. Tiếp tục cho tỏi phi vàng và 3 trái ớt cắt lát vào đảo nhanh tay trên lửa nhỏ.
Đảo cho tóp mỡ áo đều sốt, có mùi thơm nồng đặc trưng thì tắt bếp. Để nguội một chút là có thể thưởng thức ngay.
THÀNH PHẨM
Món tóp mỡ da giòn rụm, vàng ươm với lớp da nổ cốm giòn tan, phần mỡ béo ngậy. Vị mặn ngọt hài hòa, thơm lừng tỏi phi và cay nhẹ của ớt. Món này ăn vặt hay ăn kèm cơm, kho quẹt đều tuyệt vời.',
3
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Nem chua rán', 
    '/images/nemchuaran.jpg', 
    N'Cách làm nem chua rán tại nhà giòn xốp, thơm ngon, cực đơn giản', 
    N'NGUYÊN LIỆU: Nem chua rán (Cho 15 chiếc nem)
Nguyên liệu làm 
 Nạc vai 300 gr
 Giò sống 200 gr
 Bì heo 100 gr
 Chanh 1 quả
 Hành tím 20 gr
 Thính gạo 15 gr
 Bột năng 30 gr
 Trứng gà 2 quả
 Bột chiên xù 100 gr
 Gia vị thông dụng 1 ít
(hạt nêm/ đường/ tiêu/ nước mắm/ tương ớt/ muối)
Cách chọn
Mua nguyên liệu tươi ngon
1.Mua thịt nạc vai tươi ngon
Chọn thịt nạc vai có màu hồng tươi, không có mùi lạ hay dấu hiệu ôi thiu.
Thịt có độ đàn hồi tốt khi ấn vào, bề mặt khô ráo, không chảy nước hay nhớt.
2.Mua bì heo chất lượng
Chọn bì heo có màu trắng hồng tự nhiên, không có đốm đen hay vết bẩn lạ.
Bì dày vừa phải, không quá mỏng cũng không quá dày, không có mùi hôi khó chịu.
Cách chế biến
Nem chua rán
1.Sơ chế nguyên liệu làm nem chua rán
Thịt nạc vai: Rửa sạch 300gr thịt nạc vai, để thật ráo nước rồi thái miếng mỏng để dễ xay. Cho thịt vào máy xay thịt xay nhỏ.
Bì heo: Cho 100gr bì heo vào tô, thêm muối và chà xát kỹ để khử mùi hôi. Rửa lại thật sạch với nước. Cho bì vào nồi nước sôi cùng vài lát hành tím, luộc khoảng 10 phút đến khi bì mềm. Vớt bì ra, cho ngay vào tô nước đá lạnh để bì săn lại, giòn hơn. Sau đó, dùng dao lọc bỏ hết phần mỡ bám trên bì và thái sợi thật mỏng.
Mách nhỏ: Thái bì càng mỏng, nem càng giòn sần sật và ngon hơn khi ăn.
2.Trộn nhân nem chua và ướp gia vị
Cho thịt nạc vai đã xay và bì heo thái sợi vào một tô lớn. Thêm 200gr giò sống (giúp nem có độ kết dính tốt hơn) và 20gr hành tím băm nhỏ.
Nêm gia vị: 1 muỗng cà phê hạt nêm, 0.5 muỗng cà phê đường, một chút tiêu, 1 muỗng cà phê nước mắm. Trộn đều cho gia vị thấm vào các nguyên liệu.
Tiếp tục cho 2 muỗng cà phê bột năng (để tạo độ kết dính), 1 muỗng cà phê thính gạo (tạo mùi thơm đặc trưng cho nem chua) và 1 muỗng cà phê dầu ăn (giúp thịt mềm, bóng bẩy và giữ ẩm).
Dùng tay bóp trộn thật mạnh và đều để các nguyên liệu hòa quyện vào nhau, tạo thành khối nhân nem dẻo mịn.
Mách nhỏ: Giò sống đã có gia vị, nên bạn hãy nêm nếm và điều chỉnh cho vừa khẩu vị nhé!
3.Tạo hình nem và làm đông
Trải một miếng màng bọc thực phẩm lên thớt. Lấy một lượng nhân nem vừa đủ đặt lên, ém gọn lại.
Cuộn tròn chặt tay, sau đó xoắn hai đầu màng bọc lại như gói kẹo để nem được định hình chắc chắn. Làm lần lượt cho đến hết phần nhân.
Xếp nem đã tạo hình vào ngăn đông tủ lạnh khoảng 2 tiếng cho nem cứng nhẹ.
Mách nhỏ: Không nên để nem đông cứng như đá sẽ khó chiên và ảnh hưởng đến chất lượng nem.
4.Pha nước chấm thần thánh
Trong một chén nhỏ, pha nước chấm nem chua rán: 1 muỗng cà phê đường, 1 muỗng cà phê nước mắm, 2 muỗng cà phê nước lọc, 2 muỗng cà phê tương ớt, một chút tiêu, tỏi ớt băm nhỏ và 2 muỗng cà phê nước cốt chanh (nhớ bỏ hạt). Khuấy đều cho các gia vị tan hết.
5.Tẩm bột và chiên nem chua rán giòn xốp
Sau 2 tiếng, lấy nem ra khỏi tủ đông, lột bỏ lớp màng bọc thực phẩm.
Đập 2 quả trứng gà vào chén, đánh tan. Chuẩn bị một chén bột chiên xù.
Nhúng từng chiếc nem vào trứng, sau đó lăn qua bột chiên xù sao cho bột áo đều khắp nem. Lớp trứng và bột chiên xù sẽ giúp nem giòn xốp hơn khi chiên.
Đun nóng chảo với lượng dầu ăn đủ ngập nem. Khi dầu nóng, nhẹ nhàng thả nem đã tẩm bột vào chiên, tách rời các chiếc nem để không bị dính vào nhau.
Chiên nem với lửa vừa, trở đều các mặt để nem chín vàng giòn từ từ bên trong. Tránh chiên lửa quá lớn làm nem cháy bên ngoài mà bên trong chưa chín.
Khi nem vàng đều và giòn rụm, vớt ra giấy thấm dầu để loại bỏ bớt dầu thừa.
THÀNH PHẨM
Bày nem chua rán nóng hổi, vàng ươm ra đĩa. Trang trí thêm vài lát dưa leo ăn kèm.
Món nem chua rán giòn xốp, nhân thịt mềm thấm vị, bì heo sần sật không dai, thơm lừng mùi thính và tiêu sẽ khiến bạn mê mẩn. Chấm cùng nước chấm chua ngọt cay cay, cắn một miếng nghe tiếng "rộp rộp" thật đã tai.',
3
);

INSERT INTO Recipes (Name, Image, Description, RecipeDetail, CategoryId)
VALUES (
    N'Kem chuối sữa đặc', 
    '/images/kemchuoi.jpg', 
    N'Cách làm kem chuối sữa đặc dẻo thơm, béo ngậy tại ngay nhà thật đơn giản', 
    N'NGUYÊN LIỆU: Kem chuối sữa đặc (Cho 4 hộp kem nhỏ)
 Chuối xiêm chín mùi 10 trái (khoảng 850gr)
 Nước cốt dừa 500 ml (từ 400gr dừa nạo)
 Sữa đặc 200 gr
 Đường 50 gr
 Đậu phộng 100 gr
 Bột năng 10 gr (2 muỗng canh)
 Dừa rám bào sợi 1 trái (dừa cứng cậy)
 Sữa chua có đường 1 hộp (tùy chọn)
 Hương vani 1 ít (hoặc hương dầu chuối)
 Gia vị thông dụng 1 ít (muối)
Cách chọn
Mua nguyên liệu tươi ngon
1.Mua chuối
Chọn chuối xiêm chín tự nhiên, vỏ có chấm đốm đen li ti. Tránh chuối còn xanh hoặc chín ép.
Chuối chín mùi sẽ mang lại hương vị ngọt thơm và độ dẻo mịn đặc trưng cho món kem.
2.Mua đậu phộng
Chọn đậu phộng hạt đều, căng bóng, không bị lép hay mối mọt.
Khi rang, đậu phộng cần được rang vàng già để đạt độ giòn và thơm ngon nhất.
3.Mua dừa rám (dừa cứng cậy)
Chọn trái dừa rám có lớp vỏ lụa bên trong còn bám chắc vào cùi dừa.
Dừa cứng cậy sẽ cho sợi dừa dai giòn, thơm béo, tăng thêm phần hấp dẫn cho món kem.
Cách chế biến
Kem chuối sữa đặc
1.Nấu hỗn hợp kem cốt dừa sữa đặc
Cho 500ml nước cốt dừa vào nồi, thêm 50gr đường và một ít muối để kem đậm đà hơn.
Hòa tan 10gr bột năng với một ít nước lọc, sau đó đổ từ từ vào nồi nước cốt dừa.
Đặt nồi lên bếp, đun với lửa nhỏ và khuấy đều tay. Nấu cho đến khi hỗn hợp sánh lại và bột năng chín kỹ, giúp kem không bị vữa khi đông lạnh.
Tắt bếp, cho 200gr sữa đặc vào và khuấy đều. Cuối cùng, thêm một ít hương vani (hoặc hương dầu chuối) để tăng mùi thơm hấp dẫn. Nhấc nồi xuống và để hỗn hợp nguội hoàn toàn.
2.Rang đậu phộng giòn thơm
Cho 100gr đậu phộng vào chảo, rang trên lửa nhỏ. Đảo đều tay cho đến khi đậu phộng vàng già, dậy mùi thơm và giòn rụm.
Nhắc chảo xuống, để đậu phộng nguội bớt rồi bóc sạch vỏ. Giã nhẹ đậu phộng để hạt vỡ đôi, vỡ ba, tạo độ bùi khi ăn kem chuối.
3.Sơ chế chuối và dừa
10 trái chuối xiêm chín mùi (khoảng 850gr) lột sạch vỏ. Bạn nên chọn chuối chín muồi để kem có vị ngọt tự nhiên và dẻo ngon nhất.
Cắt chuối thành từng lát tròn hoặc lát xéo với độ dày tùy thích.
1 trái dừa rám (dừa cứng cậy) bào sợi nhỏ. Dừa rám sẽ mang lại độ giòn sật thú vị cho món kem.
4.Trộn sữa chua vào hỗn hợp kem
Khi hỗn hợp kem cốt dừa đã nguội hẳn, cho 1 hộp sữa chua có đường vào.
Khuấy đều tay cho sữa chua hòa quyện hoàn toàn vào hỗn hợp kem, tạo độ sánh mịn và hương vị chua nhẹ hấp dẫn.
5.Hoàn thành và đông lạnh kem chuối
Chuẩn bị các khay hoặc hộp đựng thực phẩm để làm kem.
Xếp một lớp chuối lát đều dưới đáy hộp. Rắc một lớp đậu phộng rang và dừa sợi lên trên.
Múc hỗn hợp kem cốt dừa đã nguội vào, dùng muỗng dàn đều để kem chảy lấp đầy các khoảng trống và không bị bọt khí.
Tiếp tục xen kẽ các lớp chuối, đậu phộng, dừa sợi và hỗn hợp kem cho đến khi đầy hộp.
Ở lớp trên cùng, rắc nhiều đậu phộng và dừa sợi hơn, dùng muỗng nhấn nhẹ để chúng dính vào kem.
Ngay sau khi hoàn thành mỗi hộp, hãy cho ngay vào ngăn đá tủ lạnh để đông lạnh. Việc này giúp đậu phộng giữ được độ giòn, không bị mềm.
Nếu còn thừa nguyên liệu, bạn có thể cho vào chén nhỏ và đông lạnh tương tự.
THÀNH PHẨM
Sau khoảng 4-6 tiếng trong ngăn đá, kem chuối sữa đặc sẽ đông lại và sẵn sàng để thưởng thức. Lấy kem ra, dùng nĩa hoặc muỗng để thưởng thức từng miếng kem dẻo béo, thơm lừng mùi chuối, cốt dừa, hòa quyện vị bùi của đậu phộng và giòn sật của dừa sợi. Đây chắc chắn là món tráng miệng giải nhiệt tuyệt vời cho cả gia đình!',
7
);



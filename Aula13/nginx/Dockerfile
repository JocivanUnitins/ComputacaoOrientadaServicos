FROM alpine:3.19.1

RUN apk add --no-cache nginx 

COPY ./nginx/default.conf /etc/nginx/http.d 
RUN mkdir -p /var/www/html
RUN echo "<h1>Pagina Default - UNITINS</h1>" >  /var/www/html/index.html

CMD ["nginx", "-g", "daemon off;"]
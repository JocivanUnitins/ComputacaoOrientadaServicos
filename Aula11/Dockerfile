FROM alpine:3.19.1

RUN apk add --no-cache nginx 
COPY ./nginx/default.conf /etc/nginx/http.d 
COPY ./www/index.html /var/www/html/index.html

LABEL description="WebNginx"
LABEL version="1.0"

#VOLUME /var/www/html
EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
using Proxy;

IVideo video = new ProxyVideo("example_video.mp4", false);
video.Play(); // Output: "Access denied. You are not authorized to view this video."

IVideo authorizedVideo = new ProxyVideo("example_video.mp4", true);
authorizedVideo.Play(); // Output: "Loading video: example_video.mp4" and "Playing video: example_video.mp4"